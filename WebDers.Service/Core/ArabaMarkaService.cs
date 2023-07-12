using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDers.Service.Data;
using WebDers.Service.Models;

namespace WebDers.Service.Core
{
    public class ArabaMarkaService
    {
        private readonly AppDbContext _db;
        public ArabaMarkaService(AppDbContext db)
        {
            _db = db;
        }
        public List<ArabaMarka> GetAll()
        {
            var models = _db.ArabaMarkas.ToList();
            return models;


        }
        public ArabaMarka GetById(int id)
        {
            return _db.ArabaMarkas.First(p => p.ArabaMarkaID == id);
        }
        public void Save(ArabaMarka model)
        {

            if (model.ArabaMarkaID == 0)
            {

                _db.ArabaMarkas.Add(model);

            }
            else
            {
                _db.ArabaMarkas.Update(model);
            }
            _db.SaveChanges();

        }



        public void Delete(int id)
        {
            var model = _db.ArabaMarkas.Find(id);
            _db.ArabaMarkas.Remove(model);
            _db.SaveChanges();


        }
    }
}
