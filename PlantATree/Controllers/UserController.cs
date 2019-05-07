using Microsoft.AspNetCore.Mvc;
using PlantATree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantATree.Controllers
{
    public class UserController : Controller
    {
        public ViewResult Signup()
        {
            return View();
        }

        public ViewResult Login()
        {
            return View();
        }
    }
}
