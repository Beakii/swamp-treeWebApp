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
            List<PlantInfo> testing = new List<PlantInfo>();
            testing.Add(_dbm.GetPlantInfo("Fuji Apple Tree"));
            testing.Add(_dbm.GetPlantInfo("Wonderful Pomegranate"));
            testing.Add(_dbm.GetPlantInfo("Little Giant Arborvitae"));
            return View(testing);
        }

        public ViewResult Cart()
        {
            try
            {
                UserCart c = JsonConvert.DeserializeObject<UserCart>(HttpContext.Session.GetString(SessionRef.Cart));

                return View(c.GetCartItems());
            }
            catch (ArgumentNullException){}

            return View();
        }

        public RedirectToActionResult AddToCart(string Name)
        {
            UserCart cart;

            try
            {
                cart = JsonConvert.DeserializeObject<UserCart>(HttpContext.Session.GetString(SessionRef.Cart));
                cart.AddItem(Name);
            }
            catch(ArgumentNullException)
            {
                cart = new UserCart();
                cart.AddItem(Name);
            }

            HttpContext.Session.SetString(SessionRef.Cart, JsonConvert.SerializeObject(cart));

            return RedirectToAction("Cart", "Shop");
        }

        public RedirectToActionResult RemoveFromCart(string Name)
        {
            UserCart cart;

            try
            {
                cart = JsonConvert.DeserializeObject<UserCart>(HttpContext.Session.GetString(SessionRef.Cart));
                cart.RemoveItem(Name);
                HttpContext.Session.SetString(SessionRef.Cart, JsonConvert.SerializeObject(cart));
            }
            catch (ArgumentNullException)
            {}

            return RedirectToAction("Cart", "Shop");
        }
    }
}
