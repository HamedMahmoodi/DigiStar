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
    public class EditUserModel : PageModel
    {
        private IUserService _userService;
        public EditUserModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public EditUserViewModel EditUserViewModel { get; set; }
        public void OnGet(int id)
        {
            EditUserViewModel = _userService.GetUserForShowInEditModel(id); 
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _userService.EditUserFromAdmin(EditUserViewModel);

            return Redirect("/Admin/ManageUsers");
        }
    }
}