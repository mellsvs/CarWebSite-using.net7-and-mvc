using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDers.Service.Data;
using WebDers.Service.Models;

namespace WebDers.Service.Core
{
    public class HakkimizdaService
    {
        private readonly AppDbContext _db;
        public HakkimizdaService(AppDbContext db)
        {
            _db = db;
        }
        public List<Hakkimizda> GetAll()
        {
            var models = _db.Hakkimizdas.ToList();
            return models;


        }
    }
}
