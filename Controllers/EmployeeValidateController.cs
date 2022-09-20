using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppUsingEFCore.Models;

namespace WebAppUsingEFCore.Controllers
{
    public class EmployeeValidateController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Eid, EName, MailID, Doj, Salary, password, cpassword")] EmployeeValidate emp)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    ViewBag.Message = "success";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Message = "failed";
                    return View();
                }
            }
            catch (Exception e)
            {

            }
            return View();
        }
    }
}
