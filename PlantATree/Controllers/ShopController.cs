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
        public ViewResult ProductPage(PlantInfo postPlant)
        {
            PlantInfo plant = _dbm.GetPlantInfo(postPlant.Name);

            if (plant.Valid)
            {
                return View(plant);
            }
            else
            {
                return View("NoPlant");
            }

        }

        public ViewResult Catalog()
        {
            return View(_dbm.GetAllPlants());
        }

        public ViewResult Specials()
        {
            List<PlantInfo> testing = new List<PlantInfo>();
            testing.Add(_dbm.GetPlantInfo("Fuji Apple Tree"));
            testing.Add(_dbm.GetPlantInfo("Wonderful Pomegranate"));
            testing.Add(_dbm.GetPlantInfo("Little Giant Arborvitae"));
            return View(testing);
        }

        public ViewResult Cart()
        {
            return View();
        }
    }
}
