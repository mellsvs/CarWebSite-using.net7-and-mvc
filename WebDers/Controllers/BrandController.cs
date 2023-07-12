using Microsoft.AspNetCore.Mvc;
using WebDers.Service.Core;
using WebDers.Service.Models;

namespace WebDers.Controllers
{
    public class BrandController : ControllerBase
    {
        private readonly BrandService _brandService;
          
        public BrandController(BrandService brandService) { 
            _brandService = brandService;
                }

        public IActionResult AdminAnaSayfa()
        { 
            var models = _brandService.GetAll();
            return View(models);
        }
        // GET: Admin

        public IActionResult YeniBlog()
        {
            var viewModel=_brandService.GetCreateViewModel();

                return View(viewModel);
        }

        public IActionResult Save(BrandDTO viewmodel)
        {
            if (ModelState.IsValid)
            {

                _brandService.Save(viewmodel);
                TempData["success"] = "Bilgiler Kaydedildi";
                return RedirectToAction("AdminAnaSayfa");
            }
            TempData["error"] = "Hata Oluştu.";
            return View("Edit", viewmodel);

        }
        public IActionResult Blogsil(int id)
        {
            try
            {
                _brandService.Delete(id);
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
          
            var model = _brandService.GetEditViewModel(id);
            return View(model);

        }
    }
}
