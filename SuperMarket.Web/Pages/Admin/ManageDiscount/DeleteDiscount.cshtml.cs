using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperMarket.Core.DTOs;
using SuperMarket.Core.Services.Interfaces;
using SuperMarket.Core.DTOs.Order;

namespace SuperMarket.Web.Pages.Admin.ManageDiscount
{
    public class DeleteDiscountModel : PageModel
    {
        private IOrderService _orderService;
        public DeleteDiscountModel(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public InformationDiscountViewModel InformationDiscountViewModel { get; set; }
        public void OnGet(int id)
        {
            ViewData["DiscountId"] = id;
            InformationDiscountViewModel = _orderService.GetDiscountInformation(id);
        }
        public IActionResult OnPost(int discountId)
        {
            _orderService.DeleteDiscount(discountId);
            return RedirectToPage("Index");
        }
    }
}
