using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SuperMarket.Core.Convertors;
using SuperMarket.Core.Services;
using SuperMarket.Core.Services.Interfaces;
using SuperMarket.DataLayer.Entites.User;

namespace SuperMarket.Web.Controllers
{

    public class HomeController : Controller
    {
        private IUserService _userService;
        private IProductService _productService;
        private IOrderService _orderService; 
        public HomeController(IUserService userService, IProductService productService,IOrderService orderService)
        {
            _userService = userService;
            _productService = productService;
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            ViewBag.BestsellerProduct = _productService.GetBestSellerProduct();
            ViewBag.GroupMobile = _productService.GetGroupMobile();
            if(User.Identity.IsAuthenticated)
            {
                ViewBag.OrderUserInIndex = _orderService.GetUserOrders(User.Identity.Name);
            }
            return View(_productService.GetProduct().Item1);
        }



        [Route("OnlinePayment/{id}")]
        public IActionResult OnlinePeyment(int id)
        {
            if (HttpContext.Request.Query["Status"] != "" &&
              HttpContext.Request.Query["Status"].ToString().ToLower() == "ok"
              && HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"];

                var wallet = _userService.GetWalletByWalletId(id);

                var payment = new ZarinpalSandbox.Payment(wallet.Amount);
                var res = payment.Verification(authority).Result;
                if (res.Status == 100)
                {
                    ViewBag.code = res.RefId;
                    ViewBag.IsSuccess = true;
                    wallet.IsPay = true;
                    _userService.UpdateWallet(wallet);
                }

            }

            return View();
        }

        public IActionResult GetSubGroups(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem(){Text="انتخاب کنید",Value="0"}
            };
            list.AddRange(_productService.GetSubGroupForManageProduct(id));
            return Json(new SelectList(list, "Value", "Text"));
        }

        [HttpPost]
        [Route("file-upload")]
        public IActionResult UploadImage(IFormFile upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {
            if (upload.Length <= 0) return null;

            var fileName = Guid.NewGuid() + Path.GetExtension(upload.FileName).ToLower();



            var path = Path.Combine(
                Directory.GetCurrentDirectory(), "wwwroot/MyImages",
                fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                upload.CopyTo(stream);

            }



            var url = $"{"/MyImages/"}{fileName}";


            return Json(new { uploaded = true, url });
        }

        public IActionResult Error404()
        {
            return View();
        }

        [Route("AboutUs")]
        public IActionResult AboutUs()
        {
            return View();
        }

        [Route("ContactUs")]
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        [Route("ContactUs")]
        public IActionResult ContactUs(ContactUs contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }

            DataLayer.Entites.User.ContactUs contactUs = new ContactUs()
            {
                UserName = contact.UserName,
                Mobile = contact.Mobile,
                Email = FixedText.FixEmail(contact.Email),
                ContactTitle = contact.ContactTitle,
                ContactDescription = contact.ContactDescription,
                IsDelete = false,
                IsAdminRead = false
            };
            _userService.AddContact(contact);

            ViewBag.IsSuccess = true;
            return View(contact);
        }
    }
}
