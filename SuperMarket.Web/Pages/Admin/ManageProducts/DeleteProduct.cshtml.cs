using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperMarket.Core.DTO;
using SuperMarket.Core.Services.Interfaces;

namespace SuperMarket.Web.Pages.Admin.ManageProducts
{
    public class DeleteProductModel : PageModel
    {
        private IProductService _productService;
        public DeleteProductModel(IProductService productService)
        {
            _productService = productService;
        }
        public InformationProductViewModel InformationProductViewModel { get; set; }
        public void OnGet(int id)
        {
            ViewData["ProductId"] = id;
            InformationProductViewModel = _productService.GetProductInformation(id);
        }

        public IActionResult OnPost(int ProductId)
        {
            _productService.DeleteProduct(ProductId);
            return RedirectToPage("Index");
        }
    }
}