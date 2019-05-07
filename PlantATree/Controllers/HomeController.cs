using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantATree.Models;
using PlantATree.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlantATree.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _IUserRepo;

        public HomeController(IUserRepository repo)
        {
            _IUserRepo = repo;
        }

        public ViewResult Index()
        {
            var model = _IUserRepo.GetAllUsers();
            return View(model);
        }

        public ViewResult GetUser(int? id)
        {
            GetUserViewModel viewModel = new GetUserViewModel()
            {
                UserAccount = _IUserRepo.GetUser(id ?? 1)
            };

            return View(viewModel);
        }

        [HttpGet]
        public ViewResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddUser(UserAccount acc)
        {
            _IUserRepo.AddUser(acc);
            return RedirectToAction("index");
        }

        [HttpGet]
        public ViewResult RemoveUser()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult RemoveUser(int id)
        {
            _IUserRepo.RemoveUser(id);
            return RedirectToAction("index");
        }

    }
}
