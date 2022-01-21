using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using SuperMarket.Core.DTO;
using SuperMarket.Core.DTOs.Product;
using SuperMarket.DataLayer.Entites.Product;
using System;
using System.Collections.Generic;

namespace SuperMarket.Core.Services.Interfaces
{
    public interface IProductService
    {
        #region Admin Panel

        ProductForAdminViewModel GetProducts(int pageId = 1, string filterProduct = "");
        ProductForAdminViewModel GetDeleteProducts(int pageId = 1, string filterProduct = "");

        #endregion

        #region Group

        List<ProductGroup> GetAllGroup();
        List<SelectListItem> GetGroupForManageProduct();
        List<SelectListItem> GetSubGroupForManageProduct(int groupId);
        List<SelectListItem> GetStatues();
        ProductGroup GetGroupById(int groupId);
        void AddGroup(ProductGroup group);
        void UpdateGroup(ProductGroup group);
        void DeleteProductGroup(int groupId);
        InformationProductGroupViewModel GetProductGroupInformation(int groupId);

        #endregion

        #region Product

        int AddProduct(Product product,IFormFile imgProduct);
        Product GetProductById(int productId);
        void UpdateProduct(Product product, IFormFile imgProduct);
       Tuple<List<ShowProductListItemViewModel>,int> GetProduct(int pageId=1,string filter="",string orderByType= "جدیدترین",
           string showAvailable= "خیر",string showConutProduct = "20", int startPrice=0,int endPrice=0,List<int> selectedGroups=null,int take=0);

       Product GetProductForShow(int productId);
        List<ShowProductListItemViewModel> GetBestSellerProduct();
        void UpdateProducts(Product product);
        void DeleteProduct(int productId);
        InformationProductViewModel GetProductInformation(int productId);
        List<Product> GetGroupMobile();

        #endregion

        #region Comments

        void AddComment(ProductComment comment);
        Tuple<List<ProductComment>, int> GetProductComment(int productId, int pageId = 1);

        #endregion
    }
}
