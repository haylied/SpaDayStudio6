using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user/add")]
        public IActionResult SubmitAddUserForm(User? newUser, string verify)
        {
            if (verify == newUser?.Password)
            {
                return View("Index", newUser);
                //ViewBag.n
                //return View("Index");
            }

            return View("Add");
        }


    }
}

