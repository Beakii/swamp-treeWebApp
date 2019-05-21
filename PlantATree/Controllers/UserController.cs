using Microsoft.AspNetCore.Mvc;
using PlantATree.Middleware.DatabaseManagement;
using PlantATree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantATree.Controllers
{
    public class UserController : Controller
    {
        private UserAccountDbm _dbm;

        public UserController()
        {
            _dbm = new UserAccountDbm();
        }

        [HttpPost]
        public RedirectToActionResult Review(UserAccount acc)
        {
            _dbm.AddTestimony(acc);
            //return View();
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
    }
}
