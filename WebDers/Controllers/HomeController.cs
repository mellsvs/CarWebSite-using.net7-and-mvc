using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebDers.Service.Core;
using WebDers.Service.Models;

namespace WebDers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly İletisimService _iletisimService;
        private readonly HakkimizdaService _hakkimizdaService;
        public HomeController(/*İletisimService iletisimService, */HakkimizdaService hakkimizdaService)
        {
            //_iletisimService = iletisimService;
            _hakkimizdaService = hakkimizdaService;
        }
   

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Iletisim()
        {
            //var models = _iletisimService.GetAll();
            //return View(models);
            return View();
        
        }
        public IActionResult About()
        {
            var models = _hakkimizdaService.GetAll();
            return View(models);


        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}