using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SuperMarket.Core.Services.Interfaces;
using SuperMarket.DataLayer.Entites.Product;

namespace SuperMarket.Web.Pages.Admin.ManageProducts
{
    public class CreateProductModel : PageModel
    {
        private IProductService _productService;
        public CreateProductModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public Product Product { get; set; }
        public void OnGet()
        {
            var groups = _productService.GetGroupForManageProduct();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");

            var subGroups = _productService.GetSubGroupForManageProduct(int.Parse(groups.First().Value));
            ViewData["SubGroups"] = new SelectList(subGroups, "Value", "Text");

            var statues = _productService.GetStatues();
            ViewData["Statues"] = new SelectList(statues, "Value", "Text");

        }

        public IActionResult OnPost(IFormFile imgProductUp)
        {
            if(!ModelState.IsValid)
            return Page();

            _productService.AddProduct(Product, imgProductUp);
            return RedirectToPage("Index");
        }
    }
}