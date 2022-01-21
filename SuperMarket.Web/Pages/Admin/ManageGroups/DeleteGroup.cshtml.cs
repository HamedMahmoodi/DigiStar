using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperMarket.Core.DTO;
using SuperMarket.Core.Services.Interfaces;

namespace SuperMarket.Web.Pages.Admin.ManageGroups
{
    public class DeleteGroupModel : PageModel
    {
        private IProductService _productService;
        public DeleteGroupModel(IProductService productService)
        {
            _productService = productService;
        }
        public InformationProductGroupViewModel InformationProductGroupViewModel { get; set; }
        public void OnGet(int id)
        {
            ViewData["GroupId"] = id;
            InformationProductGroupViewModel = _productService.GetProductGroupInformation(id);
        }
        public IActionResult OnPost(int GroupId)
        {
            _productService.DeleteProductGroup(GroupId);
            return RedirectToPage("Index");
        }
    }
}
