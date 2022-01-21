using SuperMarket.Core.DTOs.Order;
using SuperMarket.DataLayer.Entites.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.Core.Services.Interfaces
{
   public interface IOrderService
    {
        #region Order

        int AddOrder(string mobile, int productId);
        void UpdatePriceOrder(int orderId);
        Order GetOrderForUserPanel(string mobile, int orderId);
        Order GetOrderById(int orderId);
        bool FinalyOrder(string mobile, int orderId);
        List<Order> GetUserOrders(string mobile);
        void UpdateOrder(Order order);
        int DeleteItemOrder(int productId,string mobile);

        #endregion

        #region Discount

        DiscountUseType UseDiscount(int oredrId, string code);
        InformationDiscountViewModel GetDiscountInformation(int discountId);
        void AddDiscount(Discount discount);
        List<Discount> GetAllDiscounts();
        Discount GetDiscountById(int discountId);
        void UpdateDiscount(Discount discount);
        void DeleteDiscount(int discountId);
        bool IsExistCode(string code);

        #endregion
    }
}
