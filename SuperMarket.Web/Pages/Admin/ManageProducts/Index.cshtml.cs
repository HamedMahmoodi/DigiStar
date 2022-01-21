using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperMarket.Core.DTO;
using SuperMarket.Core.DTOs.Product;
using SuperMarket.Core.Services.Interfaces;
using SuperMarket.DataLayer.Entites.Product;

namespace SuperMarket.Web.Pages.Admin.ManageProducts
{
    public class IndexModel : PageModel
    {
        private IProductService _productService;
        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public ProductForAdminViewModel ProductForAdminViewModel { get; set; }
        public List<ProductGroup> ProductGroups { get; set; }
        public void OnGet(int pageId = 1, string filterProduct = "")
        {
            ProductForAdminViewModel = _productService.GetProducts(pageId, filterProduct);
            ProductGroups = _productService.GetAllGroup();
        }
    }
}