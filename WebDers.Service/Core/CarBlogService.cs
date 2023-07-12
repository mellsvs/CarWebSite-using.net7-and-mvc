using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDers.Service.Data;
using WebDers.Service.Models;

namespace WebDers.Service.Core
{
    public class CarBlogService
    {
        private readonly AppDbContext _db;

        public CarBlogService(AppDbContext db)
        {
            _db = db;
        }
        public List<CarBlog> GetAll()
        {
            var models = _db.CarBlogs.ToList();
            return models;


        }
        public CarBlog GetById(int id)
        {
            return _db.CarBlogs.First(p => p.CarBlogID == id);
        }
    }
 
}

