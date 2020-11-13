using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user/submit")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.error = "";
            if(verify != newUser.Password)
            {
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                ViewBag.error = "The password and verify password fields must match";
                return View("Add");
                
            }
            else
            {
                ViewBag.user = newUser;
                return View("Index");
            }
        }
    }
}
