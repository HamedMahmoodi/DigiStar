using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperMarket.Core.DTOs;
using SuperMarket.Core.Services.Interfaces;

namespace SuperMarket.Web.Pages.Admin.ManageUsers
{
    public class CreateUserModel : PageModel
    {
        private IUserService _userService;
        public CreateUserModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public CreateUserViewModel CreateUserViewModel { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost(/*CreateUserViewModel user*/)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //در صورت قرار دادن کدهای زیر هم کار نمیکنه هم کلا مانع اد شدن یوزر میشه
            //if (_userService.IsExistMobile(user.Mobile))
            //{
            //    ModelState.AddModelError("mobile", "شماره موبایل معتبر نمی باشد");
            //    return Page();
            //}
            int userId = _userService.AddUserFromAdmin(CreateUserViewModel);

            return Redirect("/Admin/ManageUsers");
        }

    }
}