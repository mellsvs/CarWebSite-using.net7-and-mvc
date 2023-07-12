using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDers.Service.Models;

namespace WebDers.Service.DTO
{
    public class SessionInfo
    {

        public int UserID { get; set; }
        public string Username { get; set; }
        public string? UserSurname { get; set; }
        public string? Password { get; set; }
        public string UserEmail { get; set; }
        public string? UserTel { get; set; }
        public int RoleId { get; set; }


    }
}
