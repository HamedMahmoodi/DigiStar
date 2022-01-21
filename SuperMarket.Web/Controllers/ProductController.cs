using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Core.Services.Interfaces;
using SuperMarket.DataLayer.Entites.Product;
using System;
using System.Collections.Generic;

namespace SuperMarket.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        private IOrderService _orderService;
        private IUserService _userService;
        public ProductController(IProductService productService, IOrderService orderService, IUserService userService)
        {
            _productService = productService;
            _orderService = orderService;
            _userService = userService;
        }
        public IActionResult Index(int pageId = 1, string filter = "",
            string orderByType = "جدیدترین", string showAvailable = "خیر", string showConutProduct = "20", int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null)
        {
            ViewBag.orderByType = orderByType;
            ViewBag.showConutProduct = showConutProduct;
            ViewBag.showAvailable = showAvailable;
            ViewBag.selectedGroups = selectedGroups;
            ViewBag.Groups = _productService.GetAllGroup();
            ViewBag.pageId = pageId;
            return View(_productService.GetProduct(pageId, filter, orderByType, showAvailable, showConutProduct, startPrice, endPrice, selectedGroups, 20));
        }

        [Route("ShowProduct/{id}")]
        public IActionResult ShowProduct(int id)
        {
            var product = _productService.GetProductForShow(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [Authorize]
        public ActionResult BuyProduct(int id)
        {
            int orderId = _orderService.AddOrder(User.Identity.Name, id);
            return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderId);
        }

        [HttpPost]
        public IActionResult CreateComment(ProductComment comment)
        {
            comment.IsDelete = false;
            comment.CreateDate = DateTime.Now;
            comment.UserId = _userService.GetUserIdByMobile(User.Identity.Name);
            _productService.AddComment(comment);

            return View("ShowComment", _productService.GetProductComment(comment.ProductId));
        }

        public IActionResult ShowComment(int id, int pageId = 1)
        {
            return View(_productService.GetProductComment(id, pageId));
        }
    }
}
