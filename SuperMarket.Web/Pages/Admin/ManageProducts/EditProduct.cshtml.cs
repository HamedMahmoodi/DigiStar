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
    public class EditProductModel : PageModel
    {
        private IProductService _productService;
        public EditProductModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public Product Product { get; set; }
        public void OnGet(int id)
        {
            Product = _productService.GetProductById(id);

            var groups = _productService.GetGroupForManageProduct();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text",Product.GroupId);

            List<SelectListItem> subgroups = new List<SelectListItem>()
            {
                new SelectListItem(){Text="انتخاب کنید",Value=""}
            };
            subgroups.AddRange(_productService.GetSubGroupForManageProduct(Product.GroupId));
            string selectedSubGroup = null;
            if(Product.SubGroup !=null)
            {
                selectedSubGroup = Product.SubGroup.ToString();
            }
            ViewData["SubGroups"] = new SelectList(subgroups, "Value", "Text", selectedSubGroup);

            var statues = _productService.GetStatues();
            ViewData["Statues"] = new SelectList(statues, "Value", "Text", Product.StatusId);
        }
        public IActionResult OnPost(IFormFile imgProductUp)
        {
            if (!ModelState.IsValid)
                return Page();

            _productService.UpdateProduct(Product, imgProductUp);
            return RedirectToPage("Index");
        }
    }
}