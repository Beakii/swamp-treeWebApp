using Microsoft.AspNetCore.Mvc;
using PlantATree.Middleware.DatabaseManagement;
using PlantATree.Models;
using Microsoft.AspNetCore.Http;

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
            return View(model);
        }
    }
}
