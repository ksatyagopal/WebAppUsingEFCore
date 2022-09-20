using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppUsingEFCore.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult Login(string uname, string pwd)
        {
            if(uname == "Admin" && pwd == "admin")
            {
                return RedirectToAction("Index","Products");
            }
            return View("Login");
        }
    }
}
