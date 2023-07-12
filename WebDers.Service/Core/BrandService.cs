using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDers.Service.Data;

using WebDers.Service.Models;

namespace WebDers.Service.Core
{
    public class BrandService
    {
        private readonly AppDbContext _db;
        public BrandService(AppDbContext db)
        {
            _db = db;
        }
        public List<BrandDTO> GetAll()
        {
            var models = _db.Brands.Include(p =>p.ArabaMarka).ToList();
            var dtoList = new List<BrandDTO>();
            foreach (var model in models)
            {
                var dto = new BrandDTO
                {
                    BrandID = model.BrandID,
                    BrandName = model.BrandName,
                    BrandPrice = model.BrandPrice,
                    BrandYear = model.BrandYear,
                    ArabaMarkaID = model.ArabaMarkaID,
                    ArabaMarkaName=model.ArabaMarka.ArabaMarkaName
                };

                dtoList.Add(dto);
            }
            return dtoList;


        }
        public BrandDTO GetCreateViewModel()
        {
            var dto = new BrandDTO();
            dto.ArabaMarkaList = _db.ArabaMarkas.ToList();
            return dto;
        }
        public BrandDTO GetEditViewModel()
        {
            var dto = GetCreateViewModel();

            return dto;
        }
        public void Save(BrandDTO dto)
        {

            if (dto.BrandID == 0)
            {
                var model = new Brand
                {
                    ArabaMarkaID = dto.ArabaMarkaID,
                    BrandName = dto.BrandName,
                    BrandPrice = dto.BrandPrice,
                    BrandYear = dto.BrandYear,


                };
                _db.Brands.Add(model);

            }
            else
            {
                var model = _db.Brands.Find(dto.BrandID);
                model.ArabaMarkaID=dto.ArabaMarkaID;
                model.BrandName = dto.BrandName;
                model.BrandPrice = dto.BrandPrice;
                model.BrandYear = dto.BrandYear;
                
                _db.Brands.Update(model);
            }
            _db.SaveChanges();

        }



        public void Delete(int id)
        {
            var model = _db.Brands.Find(id);
            _db.Brands.Remove(model);
            _db.SaveChanges();


        }

        public BrandDTO GetEditViewModel(int id)
        {
           var model = _db.Brands.First(p => p.BrandID == id);
            var dto = new BrandDTO
            {
                BrandID = model.BrandID,
                BrandName = model.BrandName,
                BrandPrice = model.BrandPrice,
                BrandYear = model.BrandYear,
                ArabaMarkaID = model.ArabaMarkaID,

            };
            dto.ArabaMarkaList=_db.ArabaMarkas.ToList();
            return dto;

        }
    }
}
