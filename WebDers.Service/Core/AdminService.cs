using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDers.Service.Data;
using WebDers.Service.Models;

namespace WebDers.Service.Core
{
    public class AdminService
    {
        private readonly AppDbContext _db;
        public AdminService(AppDbContext db)
        {
            _db = db;
        }
        public List<CarBlog> GetAll()
        {
            var models=_db.CarBlogs.ToList();
            return models;
                

        }
        public CarBlog GetById(int id)
        {
            return _db.CarBlogs.First(p=>p.CarBlogID==id);
        }
        public void Save(CarBlog model)
        {

            if (model.CarBlogID == 0)
            {

                _db.CarBlogs.Add(model);

            }
            else
            {
                _db.CarBlogs.Update(model);
            }
            _db.SaveChanges();

        }
           


        public void Delete(int id)
        {
            var model = _db.CarBlogs.Find(id);
            _db.CarBlogs.Remove(model);
            _db.SaveChanges();
         

        }
    }
    }

