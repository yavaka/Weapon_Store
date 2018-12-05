using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Weapon_Store.Client.Models;
using Microsoft.AspNetCore.Identity;

namespace Weapon_Store.Client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index","LoginHome");
            }
            return View();
        }

        public IActionResult Contact()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Contact", "LoginHome");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
