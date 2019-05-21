using Microsoft.AspNetCore.Mvc;
using PlantATree.Middleware.DatabaseManagement;
using PlantATree.Models;
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

        [HttpPost]
        public ViewResult ProductPage(PlantInfo plant)
        {
            //search plant
            //add bool for valid plant
            //return plant if true
            //return error if false
            return View(_dbm.GetPlantInfo(plant.Name));
        }

        public ViewResult Catalog()
        {
            return View();
        }

        public ViewResult Specials()
        {

            return View(_dbm.GetPlantInfo("Plant 2"));
        }
    }
}
