using Microsoft.EntityFrameworkCore;
using SuperMarket.Core.DTOs.Order;
using SuperMarket.Core.Services.Interfaces;
using SuperMarket.DataLayer.Context;
using SuperMarket.DataLayer.Entites.Order;
using SuperMarket.DataLayer.Entites.Product;
using SuperMarket.DataLayer.Entites.User;
using SuperMarket.DataLayer.Entites.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperMarket.Core.Services
{
    public class OrderService : IOrderService
    {
        private SuperMarketContext _context;
        private IUserService _userService;
        public OrderService(SuperMarketContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public void AddDiscount(Discount discount)
        {
            _context.Discounts.Add(discount);
            _context.SaveChanges();
        }

        public int AddOrder(string mobile, int productId)
        {
            int userId = _userService.GetUserIdByMobile(mobile);
            Order order = _context.Orders.FirstOrDefault(o => o.UserId == userId && !o.IsFinaly);

            var product = _context.Products.Find(productId);
            if (order == null)
            {
                order = new Order()
                {
                    UserId = userId,
                    IsFinaly = false,
                    CreateDate = DateTime.Now,
                    OrderSum = product.ProductPrice,
                    OrderDetails = new List<OrderDetail>()
                    {
                        new OrderDetail()
                        {
                            ProductId=productId,
                            Count=1,
                            Price=product.ProductPrice
                        }
                    }
                };
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            else
            {
                OrderDetail detail = _context.OrderDetails
                    .FirstOrDefault(d => d.OrderId == order.OrderId && d.ProductId == productId);
                if (detail != null)
                {
                    detail.Count += 1;
                    _context.OrderDetails.Update(detail);
                }
                else
                {
                    detail = new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        Count = 1,
                        ProductId = productId,
                        Price = product.ProductPrice
                    };
                    _context.OrderDetails.Add(detail);
                }
                _context.SaveChanges();
                UpdatePriceOrder(order.OrderId);
            }
            return order.OrderId;
        }

        public bool FinalyOrder(string mobile, int orderId)
        {
            int userId = _userService.GetUserIdByMobile(mobile);
            var order = _context.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                .FirstOrDefault(o => o.OrderId == orderId && o.UserId == userId);

            if (order == null || order.IsFinaly)
            {
                return false;
            }

            if (_userService.BalanceUserWallet(mobile) >= order.OrderSum)
            {
                order.IsFinaly = true;
                _userService.AddWallet(new Wallet()
                {
                    Amount = order.OrderSum,
                    CreateDate = DateTime.Now,
                    IsPay = true,
                    Description = "فاکتورشماره #" + order.OrderId,
                    UserId = userId,
                    TypeId = 2
                });
                _context.Orders.Update(order);

                foreach (var detail in order.OrderDetails)
                {
                    _context.UserProducts.Add(new UserProduct()
                    {
                        ProductId = detail.ProductId,
                        UserId = userId
                    });
                }
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Discount> GetAllDiscounts()
        {
            return _context.Discounts.ToList();
        }

        public Discount GetDiscountById(int discountId)
        {
            return _context.Discounts.Find(discountId);
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders.Find(orderId);
        }

        public Order GetOrderForUserPanel(string mobile, int orderId)
        {
            int userId = _userService.GetUserIdByMobile(mobile);
            return _context.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                .FirstOrDefault(o => o.UserId == userId && o.OrderId == orderId);
        }

        public List<Order> GetUserOrders(string mobile)
        {
            int userId = _userService.GetUserIdByMobile(mobile);
            return _context.Orders.Where(o => o.UserId == userId).Include(o=>o.OrderDetails).ThenInclude(od => od.Product).ToList();
        }

        public bool IsExistCode(string code)
        {
            return _context.Discounts.Any(d => d.DiscountCode == code);
        }

        public int DeleteItemOrder( int productId,string mobile)
        {
            int userId = _userService.GetUserIdByMobile(mobile);
            Order order = _context.Orders.FirstOrDefault(o => o.UserId == userId && !o.IsFinaly);
            var product = _context.Products.Find(productId);
            OrderDetail detail = _context.OrderDetails
                  .FirstOrDefault(d => d.OrderId == order.OrderId && d.ProductId == productId);
            if (detail?.Count <= 1)
            {
                _context.OrderDetails.Remove(detail);
            }
            else if (detail != null)
            {
                detail.Count -= 1;
            }
            _context.SaveChanges();
            UpdatePriceOrder(order.OrderId);
            return order.OrderId;
        }
        public void UpdateDiscount(Discount discount)
        {
            _context.Discounts.Update(discount);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void UpdatePriceOrder(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            order.OrderSum = _context.OrderDetails.Where(d => d.OrderId == orderId).Sum(d => d.Price * d.Count);
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public DiscountUseType UseDiscount(int oredrId, string code)
        {
            var discount = _context.Discounts.SingleOrDefault(d => d.DiscountCode == code);
            if (discount == null)
                return DiscountUseType.NotFound;

            if (discount.StartDate != null && discount.StartDate < DateTime.Now)
                return DiscountUseType.ExpireDate;

            if (discount.EndDate != null && discount.EndDate >= DateTime.Now)
                return DiscountUseType.ExpireDate;

            if (discount.UsableCount != null && discount.UsableCount < 1)
                return DiscountUseType.Finished;

            var order = GetOrderById(oredrId);

            if (_context.UserDiscountCodes.Any(d => d.UserId == order.UserId && d.DiscountId == discount.DiscountId))
                return DiscountUseType.UserUsed;

            int percent = (order.OrderSum * discount.DiscountPercent) / 100;
            order.OrderSum = order.OrderSum - percent;

            UpdateOrder(order);

            if (discount.UsableCount != null)
            {
                discount.UsableCount -= 1;
            }

            _context.Discounts.Update(discount);
            _context.UserDiscountCodes.Add(new UserDiscountCode()
            {
                UserId = order.UserId,
                DiscountId = discount.DiscountId
            });
            _context.SaveChanges();


            return DiscountUseType.Success;
        }

        public InformationDiscountViewModel GetDiscountInformation(int discountId)
        {
            var discount = GetDiscountById(discountId);
            InformationDiscountViewModel information = new InformationDiscountViewModel();
            information.DiscountCode = discount.DiscountCode;
            information.DiscountPercent = discount.DiscountPercent;
            information.StartDate = discount.StartDate;
            information.EndDate = discount.EndDate;

            return information;
        }

        public void DeleteDiscount(int discountId)
        {
            Discount discount = GetDiscountById(discountId);
            discount.IsDelete = true;
            UpdateDiscount(discount);
        }
    }
}
