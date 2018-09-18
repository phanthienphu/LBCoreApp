using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LBCoreApp.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LBCoreApp.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
       private readonly  SignInManager<AppUser> _signInManager;
        public AccountController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            //_logger.LogInformation("User logged out.");
            return Redirect("/Admin/Login/Index");
        }
    }
}