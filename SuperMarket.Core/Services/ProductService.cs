using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SuperMarket.Core.Convertors;
using SuperMarket.Core.DTO;
using SuperMarket.Core.DTOs.Product;
using SuperMarket.Core.Generator;
using SuperMarket.Core.Security;
using SuperMarket.Core.Services.Interfaces;
using SuperMarket.DataLayer.Context;
using SuperMarket.DataLayer.Entites.Product;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SuperMarket.Core.Services
{
    public class ProductService : IProductService
    {
        private SuperMarketContext _context;
        public ProductService(SuperMarketContext context)
        {
            _context = context;
        }

        public int AddProduct(Product product, IFormFile imgProduct)
        {
            product.CreateDate = DateTime.Now;
            product.ProductImageName = "no_image.jpg";

            if (imgProduct != null && imgProduct.IsImage())
            {
                product.ProductImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgProduct.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/products/image", product.ProductImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgProduct.CopyTo(stream);
                }

                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/products/thumb", product.ProductImageName);
                imgResizer.Image_resize(imagePath, thumbPath, 150);
            }

            _context.Add(product);
            _context.SaveChanges();

            return product.ProductId;
        }

        public List<ProductGroup> GetAllGroup()
        {
            return _context.ProductGroups.Include(p => p.ProductGroups).ToList();
        }

        public List<SelectListItem> GetGroupForManageProduct()
        {
            return _context.ProductGroups.Where(g => g.ParentId == null)
                  .Select(g => new SelectListItem()
                  {
                      Text = g.GroupTitle,
                      Value = g.GroupId.ToString()
                  }).ToList();
        }

        public Tuple<List<ShowProductListItemViewModel>, int> GetProduct(int pageId = 1, string filter = "",
            string orderByType = "جدیدترین", string showAvailable = "خیر", string showConutProduct = "20", int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null, int take = 0)
        {
            if (take == 0)
                take = 15;

            IQueryable<Product> result = _context.Products;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(p => p.ProductTitle.Contains(filter));
            }

            switch (orderByType)
            {
                case "ارزان ترین":
                    {
                        result = result.OrderBy(p => p.ProductPrice);
                        break;
                    }
                case "جدیدترین":
                    {
                        result = result.OrderByDescending(p => p.CreateDate);
                        break;
                    }

                case "پرفروش ترین":
                    {
                        result = result.Include(p => p.OrderDetails).Where(p => p.OrderDetails.Any())
                .OrderByDescending(d => d.OrderDetails.Count);
                        break;
                    }
                case "گران ترین":
                    {
                        result = result.OrderByDescending(p => p.ProductPrice);
                        break;
                    }
            }

            switch (showAvailable)
            {
                case "خیر":
                    {
                        break;
                    }

                case "بله":
                    {
                        result = result.Where(p => p.StatusId == 1);
                        break;
                    }
            }

            switch (showConutProduct)
            {
                case "10":
                    {
                        take = 10;
                        break;
                    }

                case "20":
                    break;

                case "40":
                    {
                        take = 40;
                        break;
                    }

                case "100":
                    {
                        take = 100;
                        break;
                    }
            }

            if (startPrice > 0)
            {
                result = result.Where(p => p.ProductPrice > startPrice);
            }
            if (endPrice > 0)
            {
                result = result.Where(p => p.ProductPrice < endPrice);
            }

            if (selectedGroups != null && selectedGroups.Any())
            {
                foreach (int groupId in selectedGroups)
                {
                    result = result.Where(p => p.GroupId == groupId || p.SubGroup == groupId);
                }
            }

            int skip = (pageId - 1) * take;

            int pageCount = result.Select(p => new ShowProductListItemViewModel()
            {
                ProductId = p.ProductId,
                StatusId = p.StatusId,
                ImageName = p.ProductImageName,
                Price = p.ProductPrice,
                Title = p.ProductTitle
            }).Count() / take;

            if ((pageCount % 2) != 0)
            {
                pageCount += 1;
            }

            var query = result.Select(p => new ShowProductListItemViewModel()
            {
                ProductId = p.ProductId,
                StatusId = p.StatusId,
                ImageName = p.ProductImageName,
                Price = p.ProductPrice,
                Title = p.ProductTitle
            }).Skip(skip).Take(take).ToList();

            return Tuple.Create(query, pageCount);

        }

        public Product GetProductById(int productId)
        {
            return _context.Products.Find(productId);
        }

        public Product GetProductForShow(int productId)
        {
            return _context.Products.Include(p => p.ProductStatus).FirstOrDefault(p => p.ProductId == productId);
        }

        public List<SelectListItem> GetSubGroupForManageProduct(int groupId)
        {
            return _context.ProductGroups.Where(g => g.ParentId == groupId)
                 .Select(g => new SelectListItem()
                 {
                     Text = g.GroupTitle,
                     Value = g.GroupId.ToString()
                 }).ToList();
        }

        public void UpdateProduct(Product product, IFormFile imgProduct)
        {
            if (imgProduct != null && imgProduct.IsImage())
            {
                if (product.ProductImageName != "no_image.jpg")
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/products/image", product.ProductImageName);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                    string deletethumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/products/thumb", product.ProductImageName);
                    if (File.Exists(deletethumbPath))
                    {
                        File.Delete(deletethumbPath);
                    }
                }
                product.ProductImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgProduct.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/products/image", product.ProductImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgProduct.CopyTo(stream);
                }

                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/products/thumb", product.ProductImageName);

                imgResizer.Image_resize(imagePath, thumbPath, 150);
            }
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public List<SelectListItem> GetStatues()
        {
            return _context.ProductStatuses.Select(s => new SelectListItem()
            {
                Value = s.StatusId.ToString(),
                Text = s.StatusTitle
            }).ToList();
        }

        public List<ShowProductListItemViewModel> GetBestSellerProduct()
        {
            return _context.Products.Include(p => p.OrderDetails).Where(p => p.OrderDetails.Any())
                .OrderByDescending(d => d.OrderDetails.Count).Take(15)
                .Select(p => new ShowProductListItemViewModel()
                {
                    ProductId = p.ProductId,
                    StatusId = p.StatusId,
                    ImageName = p.ProductImageName,
                    Price = p.ProductPrice,
                    Title = p.ProductTitle
                }).ToList();
        }

        public void AddGroup(ProductGroup group)
        {
            _context.ProductGroups.Add(group);
            _context.SaveChanges();
        }

        public void UpdateGroup(ProductGroup group)
        {
            _context.ProductGroups.Update(group);
            _context.SaveChanges();
        }

        public ProductGroup GetGroupById(int groupId)
        {
            return _context.ProductGroups.Find(groupId);
        }

        public ProductForAdminViewModel GetProducts(int pageId = 1, string filterProduct = "")
        {
            IQueryable<Product> result = _context.Products;

            if (!string.IsNullOrEmpty(filterProduct))
            {
                result = result.Where(p => p.ProductTitle.Contains(filterProduct));
            }

            // Show Item In Page
            int take = 15;
            int skip = (pageId - 1) * take;

            ProductForAdminViewModel list = new ProductForAdminViewModel();
            list.CurrentPage = pageId;
            list.PageCount = result.Count() / take;
            list.Products = result.OrderByDescending(p => p.CreateDate).Skip(skip).Take(take).ToList();

            if ((list.PageCount % 2) != 0)
            {
                list.PageCount += 1;
            }
            return list;
        }

        public ProductForAdminViewModel GetDeleteProducts(int pageId = 1, string filterProduct = "")
        {
            IQueryable<Product> result = _context.Products.IgnoreQueryFilters().Where(p => p.IsDelete);

            if (!string.IsNullOrEmpty(filterProduct))
            {
                result = result.Where(p => p.ProductTitle.Contains(filterProduct));
            }

            // Show Item In Page
            int take = 10;
            int skip = (pageId - 1) * take;

            ProductForAdminViewModel list = new ProductForAdminViewModel();
            list.CurrentPage = pageId;
            list.PageCount = result.Count() / take;
            list.Products = result.OrderByDescending(p => p.CreateDate).Skip(skip).Take(take).ToList();

            if ((list.PageCount % 2) != 0)
            {
                list.PageCount += 1;
            }
            return list;
        }

        public void DeleteProduct(int productId)
        {
            Product product = GetProductById(productId);
            product.IsDelete = true;
            UpdateProducts(product);
        }

        public void UpdateProducts(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }

        public InformationProductViewModel GetProductInformation(int productId)
        {
            var product = GetProductById(productId);
            InformationProductViewModel information = new InformationProductViewModel();
            information.ProductImageName = product.ProductImageName;
            information.ProductTitle = product.ProductTitle;
            information.ProductPrice = product.ProductPrice;
            information.CreateDate = product.CreateDate;

            return information;
        }

        public void AddComment(ProductComment comment)
        {
            comment.CreateDate = DateTime.Now;
            _context.ProductComments.Add(comment);
            _context.SaveChanges();
        }

        public Tuple<List<ProductComment>, int> GetProductComment(int productId, int pageId = 1)
        {
            int take = 5;
            int skip = (pageId - 1) * take;
            int pageCount = _context.ProductComments.Where(c => !c.IsDelete && c.ProductId == productId).Count() / take;

            if ((pageCount % 2) != 0)
            {
                pageCount += 1;
            }

            return Tuple.Create(
                _context.ProductComments.Include(c => c.User).Where(c => !c.IsDelete && c.ProductId == productId).Skip(skip).Take(take)
                    .OrderByDescending(c => c.CreateDate).ToList(), pageCount);
        }

        public InformationProductGroupViewModel GetProductGroupInformation(int groupId)
        {
            var group = GetGroupById(groupId);
            InformationProductGroupViewModel information = new InformationProductGroupViewModel();
            information.GroupTitle = group.GroupTitle;

            return information;
        }

        public void DeleteProductGroup(int groupId)
        {
            ProductGroup group = GetGroupById(groupId);
            group.IsDelete = true;
            UpdateGroup(group);
        }

        public List<Product> GetGroupMobile()
        {
            return _context.Products.Where(p => p.SubGroup == 2).Take(6).ToList();
        }
    }
}

