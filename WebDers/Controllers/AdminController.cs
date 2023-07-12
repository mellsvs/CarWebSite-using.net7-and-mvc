using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using WebDers.Service.Data;
using WebDers.Service.Core;
using WebDers.Service.Models;
using WebDers.Service.DTO;
using Newtonsoft.Json;
namespace WebDers.Controllers
{
    public class AdminController : ControllerBase
    {
        private readonly AdminService _adminService;
        public AdminController(AdminService adminService )
        {
            _adminService = adminService;
        }
       
        public IActionResult AdminAnaSayfa ()
        {
            var models = _adminService.GetAll();
            return View(models);
        }
        // GET: Admin
        
        public IActionResult YeniBlog()
        {
            return View();
        }
     
        public IActionResult Save(CarBlog model )
        {
            if (!ModelState.IsValid)
            {
               
                _adminService.Save(model);
                TempData["success"] = "Bilgiler Kaydedildi";
                return RedirectToAction("AdminAnaSayfa");
            }
            TempData["error"] = "Hata Oluştu.";
            return View("YeniBlog", model);

        }
        public IActionResult Blogsil(int id)
        {
            try
            {
                _adminService.Delete(id);
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
          var model = _adminService.GetById(id);
          return View(model);

        }

 





    }
}
