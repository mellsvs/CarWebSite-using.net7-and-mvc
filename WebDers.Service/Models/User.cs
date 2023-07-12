using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebDers.Service.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string? Username { get; set; }
        [Required]
        public string? UserSurname { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string? Password { get; set; }
        [Required]
        [DisplayName("Mail Adresi")]
        public string? UserEmail { get; set; }
        [Required]
        public string? UserTel { get; set; }
        public ICollection<Siparis>? Sipariss { get; set; }



    }
}
