using Microsoft.AspNetCore.Mvc;
using PlantATree.Middleware.DatabaseManagement;
using PlantATree.Models;
using PlantATree.ViewModels;

namespace PlantATree.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _IUserRepo;
        private DBMng db;

        public HomeController(IUserRepository repo)
        {
            _IUserRepo = repo;
            db = new DBMng();
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
                UserAccount = db.GetUserInfo(id ?? 1)
            };

            //GetUserViewModel viewModel = new GetUserViewModel()
            //{
            //    UserAccount = _IUserRepo.GetUser(id ?? 1)
            //};

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
