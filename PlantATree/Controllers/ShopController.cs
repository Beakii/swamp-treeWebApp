using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantATree.Controllers
{
    public class ShopController : Controller
    {
        public ViewResult Catalog()
        {
            return View();
        }

        public ViewResult Specials()
        {
            return View();
        }
    }
}
