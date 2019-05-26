using Microsoft.AspNetCore.Mvc;
using PlantATree.Middleware.DatabaseManagement;
using PlantATree.Models;
using Microsoft.AspNetCore.Http;
using PlantATree.Middleware;
using Newtonsoft.Json;

namespace PlantATree.Controllers
{
    public class UserController : Controller
    {
        private UserAccountDbm _dbm;

        public UserController()
        {
            _dbm = new UserAccountDbm();
        }

        [HttpGet]
        public ViewResult Review()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Review(Review rev)
        {
            _dbm.AddTestimony(rev.User, rev.UserReview);
            return RedirectToAction("index", "Home");
        }

        [HttpGet]
        public ViewResult Signup()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Signup(UserAccount acc)
        {
            _dbm.AddNewUserAccount(acc);
            return RedirectToAction("index","Home");
        }

        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Login(UserAccount acc)
        {
            bool loggedIn = _dbm.UserLogin(acc);

            if (loggedIn)
            {
                HttpContext.Session.SetString(SessionRef.Username, acc.Username);
                return RedirectToAction("Catalog", "Shop");
            }
            else
            {
                return RedirectToAction("Login", "User");
            }
        }

        public RedirectToActionResult Logout()
        {
            HttpContext.Session.Remove(SessionRef.Username);
            HttpContext.Session.Remove(SessionRef.Cart);
            return RedirectToAction("SessionCheck", "User");
        }

        [HttpGet]
        public ViewResult SessionCheck()
        {
            string SessionUserName = HttpContext.Session.GetString(SessionRef.Username);

            if (SessionUserName != null)
            {
                ViewBag.Logged = SessionUserName;
            }
            else
            {
                ViewBag.Logged = "Not logged in.";
            }
            
            return View();
        }

    }
}
