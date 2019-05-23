using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            return View(_dbm.GetPlantInfo("California Privet"));
        }

        public ViewResult Cart()
        {
            try
            {
                UserCart c = JsonConvert.DeserializeObject<UserCart>(HttpContext.Session.GetString(SessionRef.Cart));

                return View(c.GetCartItems());
            }
            catch (ArgumentNullException)
            {

            }

            return View();
        }
    }
}
