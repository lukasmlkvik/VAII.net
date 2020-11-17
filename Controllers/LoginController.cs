using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VAII.Data;
using VAII.Models;

namespace VAII.Controllers
{
    public class LoginController : Controller
    {

        private VAIIDB db;
        public LoginController(VAIIDB db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(UserLoginModel userModel)
        {
            return View();
        }


        public IActionResult Register()
        {
            return View(new UserRegistrationModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserRegistrationModel userModel)
        {
            if (userModel.Username.Length < 5 || userModel.Username.Length > 25)
            {
                userModel.UsernameV = "Username must be between 5 - 25";
            } else if (db.Acounts.Any(a => a.Username.Equals(userModel.Username)))
            {
                userModel.UsernameV = "Username exist";
            } else
            {
                if (userModel.PasswordV.Equals("") && userModel.ConfirmPasswordV.Equals("")) {
                    db.Acounts.Add(new AcountModel(userModel));
                    db.SaveChanges();
                }
                userModel.UsernameV = "";
            }
            return View(userModel);
        }
    }
}