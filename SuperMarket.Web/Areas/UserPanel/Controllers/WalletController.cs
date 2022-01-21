using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Core.DTOs;
using SuperMarket.Core.Services.Interfaces;

namespace SuperMarket.Web.Areas.UserPanel.Controllers
{
    public class WalletController : Controller
    {
        private IUserService _userService;
        public WalletController(IUserService userService)
        {
            _userService = userService;
        }

        [Area("UserPanel")]
        [Authorize]
        [Route("UserPanel/Wallet")]
        public IActionResult Index()
        {
            ViewBag.ListWallet = _userService.GetWalletUser(User.Identity.Name);
            return View();
        }

        [Route("UserPanel/Wallet")]
        [HttpPost]
        public IActionResult Index(ChargeWalletViewModel chargeWallet)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.ListWallet = _userService.GetWalletUser(User.Identity.Name);
                return View(chargeWallet);
            }

            int walletId= _userService.ChargeWallet(User.Identity.Name,chargeWallet.Amount,"شارژ حساب");

            #region Online Payment

            var payment = new ZarinpalSandbox.Payment(chargeWallet.Amount);

            var res = payment.PaymentRequest("شارژ کیف پول", "https://testhaipmarket.ir/OnlinePayment/" + walletId, "Info@HupMarket.Com", "09161111111");

            if (res.Result.Status == 100)
            {
                return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + res.Result.Authority);
            }

            #endregion

            return null;
        }
    }
}
