using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pustok.Areas.Manage.ViewModels;
using Pustok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AccountController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        //public async Task<IActionResult> CreateAdmin()
        //{
        //    AppUser admin = new AppUser
        //    {
        //        FullName = "Super Admin",
        //        UserName = "superadmin1"

        //    };
        //    var result = await _userManager.CreateAsync(admin, "spAdmin22");

        //    if (!result.Succeeded)
        //    {
        //        return Ok(result.Errors);
        //    }
        //    return View();
        //}

        public IActionResult Login(AdminLoginViewModel admin)
        {
            return Ok(admin);
        }
    }
}
