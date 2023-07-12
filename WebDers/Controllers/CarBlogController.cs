using Microsoft.AspNetCore.Mvc;
using WebDers.Service.Core;
using WebDers.Service.Data;

namespace WebDers.Controllers
{
    public class CarBlogController : Controller
    {
       
        private readonly CarBlogService _carBlogService;
        public CarBlogController(CarBlogService carBlogService)
        {
            _carBlogService = carBlogService;
        }


        public IActionResult BlogGetir()
        {
            var models = _carBlogService.GetAll();
            return View(models);
        }
        public IActionResult BlogDetay(int id)
        {
            var carBlog = _carBlogService.GetById(id);

            if (carBlog == null)
            {
                // Belirtilen id ile CarBlog bulunamadı, hata mesajı veya yönlendirme yapabilirsiniz.
                return RedirectToAction("Index");
            }

            return View(carBlog);
        }




    }
}
