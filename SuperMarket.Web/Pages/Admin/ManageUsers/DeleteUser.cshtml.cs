﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperMarket.Core.DTOs;
using SuperMarket.Core.Services.Interfaces;

namespace SuperMarket.Web.Pages.Admin.ManageUsers
{
    public class DeleteUserModel : PageModel
    {
        private IUserService _userService;
        public DeleteUserModel(IUserService userService)
        {
            _userService = userService;
        }
        public InformationUserViewModel InformationUserViewModel { get; set; }
        public void OnGet(int id)
        {
            ViewData["UserId"] = id;
            InformationUserViewModel = _userService.GetUserInformation(id);
        }

        public IActionResult OnPost(int UserId)
        {
            _userService.DeleteUser(UserId);
            return RedirectToPage("Index");
        }
    }
}