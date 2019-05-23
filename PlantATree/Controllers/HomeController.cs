using Microsoft.AspNetCore.Mvc;
using PlantATree.Middleware.DatabaseManagement;
using PlantATree.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace PlantATree.Controllers
{
    public class HomeController : Controller
    {
        private UserAccountDbm dbm;

        public HomeController()
        {
            dbm = new UserAccountDbm();
        }

        public ViewResult Index()
        {
            var model = dbm.GetAllUsers();

            UserCart tst = new UserCart();
            tst.AddItem("California Privet");

            HttpContext.Session.SetString(SessionRef.Cart, JsonConvert.SerializeObject(tst));

            
            return View(model);
        }
    }
}
