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
    public class CreateGroupModel : PageModel
    {
        private IProductService _productService;
        public CreateGroupModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public ProductGroup ProductGroups { get; set; }
        public void OnGet(int? id)
        {
            ProductGroups = new ProductGroup()
            {
                ParentId=id
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _productService.AddGroup(ProductGroups);
            return RedirectToPage("Index");
        }
    }
}