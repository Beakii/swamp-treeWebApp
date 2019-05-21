using Microsoft.AspNetCore.Mvc;
using PlantATree.Middleware.DatabaseManagement;
using PlantATree.Models;
using PlantATree.ViewModels;

namespace PlantATree.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _IUserRepo;
        private UserAccountDbm dbm;

        public HomeController(IUserRepository repo)
        {
            _IUserRepo = repo;
            dbm = new UserAccountDbm();
        }

        public ViewResult Index()
        {
            //var model = _IUserRepo.GetAllUsers();

            var model = dbm.GetAllUsers();
            return View(model);
        }

        public ViewResult GetUser(int? id)
        {
            GetUserViewModel viewModel = new GetUserViewModel()
            {
                UserAccount = dbm.GetUserInfo(id ?? 1)
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
            dbm.AddNewUserAccount(acc);
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

        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public string Login(UserAccount acc)
        {
            bool loggedIn = dbm.UserLogin(acc);

            if(loggedIn == true)
            {
                return "Logged in with Username/pass: "+acc.Username+"/"+acc.Password+" with a status of "+loggedIn;
            }
            else
            {
                return "Failed to login with Username/pass: " + acc.Username + "/" + acc.Password;
            }
        }

    }
}
