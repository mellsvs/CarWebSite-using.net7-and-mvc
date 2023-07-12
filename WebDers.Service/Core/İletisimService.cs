using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDers.Service.Data;
using WebDers.Service.Models;

namespace WebDers.Service.Core
{
    public class İletisimService
    {
        private readonly AppDbContext _db;
        public İletisimService(AppDbContext db)
        {
            _db = db;
        }
        public List<Iletisim> GetAll()
        {
            var models = _db.Iletisims.ToList();
            return models;


        }
    }
}
