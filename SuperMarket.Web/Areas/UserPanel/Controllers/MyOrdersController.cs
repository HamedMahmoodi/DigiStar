using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Core.DTOs.Order;
using SuperMarket.Core.Services.Interfaces;
using SuperMarket.DataLayer.Context;
using SuperMarket.DataLayer.Entites.Order;
using SuperMarket.DataLayer.Entites.Wallet;
using ZarinpalSandbox;

namespace SuperMarket.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class MyOrdersController : Controller
    {
        private IOrderService _orderService;
        public MyOrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            return View(_orderService.GetUserOrders(User.Identity.Name));
        }

        public IActionResult ShowOrder(int id, bool finaly = false, string type = "")
        {
            var order = _orderService.GetOrderForUserPanel(User.Identity.Name, id);

            if (order == null)
            {
                return NotFound();
            }
            ViewBag.typeDiscount = type;
            ViewBag.finaly = finaly;
            return View(order);
        }

        public IActionResult FinalyOrder(int id)
        {
            if (_orderService.FinalyOrder(User.Identity.Name, id))
            {
                return Redirect("/UserPanel/MyOrders/ShowOrder/" + id + "?finaly = true");
            }
            return BadRequest();
        }

        public IActionResult UseDiscount(int orderId, string code)
        {
            DiscountUseType type = _orderService.UseDiscount(orderId, code);
            return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderId + "?type=" + type.ToString());
        }

        [Authorize]
        public IActionResult RemoveItemInOrder(int id)
        {
         int orderId=_orderService.DeleteItemOrder(id,User.Identity.Name);
            return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderId);
        }

         // TODO Order payment
        //[Authorize]
        //public IActionResult OrderPayment(int orderId)
        //{
        //    var order = _orderService.FinalyOrder(User.FindFirstValue(ClaimTypes.NameIdentifier),orderId);
        //    if (order == false)
        //        return NotFound();

        //    var payment = new Payment(_orderService.UpdatePriceOrder());


        //}
    }
}
