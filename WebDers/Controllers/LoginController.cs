using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebDers.Service.Core;
using WebDers.Service.DTO;
using WebDers.Service.Models;
namespace WebDers.Controllers
{
    public class LoginController : Controller
    {
        private LoginService _loginService;
      public LoginController( LoginService loginService) { 
        _loginService = loginService;
        }

        public SessionInfo UserSession
        {
            get
            {
                var value = HttpContext.Session.GetString("UserSessionInfo");
                return value == null ? default(SessionInfo) : JsonConvert.DeserializeObject<SessionInfo>(value);

            }

            set
            {
                JsonSerializerSettings jss = new JsonSerializerSettings();
                var JsonString = JsonConvert.SerializeObject(value);
                HttpContext.Session.SetString("UserSessionInfo", JsonString);
            }
        }
        public IActionResult Index()
        {
            return View();


        }
        public IActionResult IndexGiris()
        {
            return View();


        }
        [HttpPost]
        public IActionResult Login(LoginViewModel viewModel)
        {
            var user = _loginService.CheckUser(viewModel);
            if(user == null)
            {
                TempData["error"] = "Hata oluştu";
                return RedirectToAction("IndexGiris","Login");
            }
            else
            {
                TempData["success"] = "Giriş başarılı";
               

            }
            UserSession = new SessionInfo
            {
                UserID = user.UserID,
                Username = user.Username,

            };
            return RedirectToAction("AdminAnaSayfa","Admin");

            


        }
        public IActionResult UyeOl()
        {
            var model = new UyeOlViewModel(); // UyeOlViewModel, uygun model sınıfınızı temsil eder
            return View(model);


        }
        [HttpPost]
        public IActionResult UyeOl(UyeOlViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    
                    UserEmail = viewModel.UserEmail,
                    Password = viewModel.Password,
                    
                };

                _loginService.CreateUser(user);

                TempData["success"] = "Üyelik oluşturuldu. Giriş yapabilirsiniz.";
                return RedirectToAction("AnaSayfa", "Admin");
            }

            return View(viewModel);
        }
        public ActionResult LogOut()
        {
            return RedirectToAction("Index", "Home");
        }

    }
}
