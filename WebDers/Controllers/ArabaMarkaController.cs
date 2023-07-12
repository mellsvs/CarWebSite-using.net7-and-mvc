using Microsoft.AspNetCore.Mvc;
using WebDers.Service.Core;
using WebDers.Service.Models;

namespace WebDers.Controllers
{
    public class ArabaMarkaController : ControllerBase
    {

        private readonly ArabaMarkaService _arabaMarkaService;
        public ArabaMarkaController(ArabaMarkaService arabaMarkaService)
        {
            _arabaMarkaService = arabaMarkaService;
        }
        public IActionResult AdminAnaSayfa()
        {
            var models = _arabaMarkaService.GetAll();
            return View(models);
        }
        // GET: Admin

        public IActionResult YeniBlog()
        {
            return View();
        }

        public IActionResult Save(ArabaMarka model)
        {
            if (!ModelState.IsValid)
            {

                _arabaMarkaService.Save(model);
                TempData["success"] = "Bilgiler Kaydedildi";
                return RedirectToAction("AdminAnaSayfa");
            }
            TempData["error"] = "Hata Oluştu.";
            return View("YeniBlog", model);

        }
        public IActionResult BlogSil(int id)
        {
            try
            {
                _arabaMarkaService.Delete(id);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Bir Hata oluştu";
                return RedirectToAction("AdminAnaSayfa");
            }

            TempData["success"] = "Bilgiler Silindi";
            return RedirectToAction("AdminAnaSayfa");


        }

        public IActionResult Edit(int id)
        {
            var model = _arabaMarkaService.GetById(id);
            return View(model);

        }
    }
}
