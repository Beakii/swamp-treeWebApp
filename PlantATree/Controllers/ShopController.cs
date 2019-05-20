using Microsoft.AspNetCore.Mvc;
using PlantATree.Middleware.DatabaseManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantATree.Controllers
{
    public class ShopController : Controller
    {

        private PlantSearchDbm _dbm;

        public ShopController()
        {
            _dbm = new PlantSearchDbm();
        }

        public ViewResult ProductPage()
        {
            return View();
        }

        public ViewResult Catalog()
        {
            return View();
        }

        public ViewResult Specials()
        {

            return View(_dbm.GetPlantInfo());
        }
    }
}
