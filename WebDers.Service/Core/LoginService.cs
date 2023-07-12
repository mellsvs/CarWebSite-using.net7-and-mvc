using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WebDers.Service.Data;
using WebDers.Service.DTO;
using WebDers.Service.Models;

namespace WebDers.Service.Core
{
    public class LoginService
    {
        private readonly AppDbContext _db;
        public LoginService(AppDbContext db)
        {
            _db = db;
        }
       
        public User CheckUser(LoginViewModel viewModel)
        {
        var user = _db.Users.FirstOrDefault(p => p.UserEmail == viewModel.UserEmail && p.Password==viewModel.Password);
            return user;

        }
        public void CreateUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }






    }
}
