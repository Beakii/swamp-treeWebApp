using Microsoft.AspNetCore.Mvc;
using PlantATree.Middleware.DatabaseManagement;
using PlantATree.Models;
using Microsoft.AspNetCore.Http;
using PlantATree.Middleware;

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

        public const string SessionLoggedIn = "_Name";

        [HttpPost]
        public string Login(UserAccount acc)
        {
            bool loggedIn = _dbm.UserLogin(acc);

            if (loggedIn == true)
            {
                
                return "Logged in with Username/pass: " + acc.Username + "/" + acc.Password + " with a status of " + loggedIn;
            }
            else
            {
                return "Failed to login with Username/pass: " + acc.Username + "/" + acc.Password;
            }
        }

        [HttpGet]
        public ViewResult SessionCheck()
        {
            ViewBag.Logged = HttpContext.Session.GetString(SessionLoggedIn);
            return View();
        }

    }
}
