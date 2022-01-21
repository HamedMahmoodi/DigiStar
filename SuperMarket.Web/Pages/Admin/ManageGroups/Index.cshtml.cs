using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperMarket.Core.Services.Interfaces;
using SuperMarket.DataLayer.Entites.Product;

namespace SuperMarket.Web.Pages.Admin.ManageGroups
{
    public class IndexModel : PageModel
    {
        private IProductService _productService;
        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<ProductGroup> ProductGroups { get; set; }
        public void OnGet()
        {
            ProductGroups = _productService.GetAllGroup();
        }
    }
}