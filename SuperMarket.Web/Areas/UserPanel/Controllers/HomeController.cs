using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Core.Convertors;
using SuperMarket.Core.DTOs;
using SuperMarket.Core.Services.Interfaces;

namespace SuperMarket.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class HomeController : Controller
    {
        private IUserService _userService;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View(_userService.GetUserInformation(User.Identity.Name));
        }

        [Route("UserPanel/EditProfile")]
        public IActionResult EditProfile()
        {
            return View(_userService.GetDataForEditProfileUser(User.Identity.Name));
        }

        [Route("UserPanel/EditProfile")]
        [HttpPost]
        public IActionResult EditProfile(EditProfileViewModel profile)
        {
            if (!ModelState.IsValid)
                return View(profile);
            if (_userService.IsExistEmail(FixedText.FixEmail(profile.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل وارد شده قبلا ثبت نام کرده است.");
                return View(profile);
            }

            _userService.EditProfile(User.Identity.Name, profile);

            ViewBag.IsSuccess = true;

            return View(_userService.GetDataForEditProfileUser(User.Identity.Name));
        }

        [Route("UserPanel/ChangePassword")]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [Route("UserPanel/ChangePassword")]
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel changePassword)
        {
            string currentMobile = User.Identity.Name;
            if (!ModelState.IsValid)
                return View(changePassword);

            if(!_userService.CompareOldPassword(changePassword.OldPassword,currentMobile))
            {
                ModelState.AddModelError("OldPassword", "کلمه عبور فعلی صحیح نمی باشد");
                return View(changePassword);
            }

            _userService.ChangeUserPassword(currentMobile, changePassword.Password);
            ViewBag.IsSuccess = true;

            return View();
        }
    }
}
