using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperMarket.Core.DTOs;
using SuperMarket.Core.Services.Interfaces;

namespace SuperMarket.Web.Pages.Admin.ManageContactUs
{
    public class IndexModel : PageModel
    {
        private IUserService _userService;
        public IndexModel(IUserService userService)
        {
            _userService = userService;
        }

        public ContactUsForAdminViewModel ContactUsForAdminViewModel { get; set; }
        public void OnGet(int pageId = 1,string filterEmail="",string filterMobile = "")
        {
            ContactUsForAdminViewModel = _userService.GetUserContactUs(pageId,filterEmail,filterMobile);
        }
    }
}
