using System.ComponentModel.DataAnnotations;

namespace WebDers.Service.DTO
{
    public class UyeOlViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı zorunludur")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "E-posta zorunludur")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz")]

        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Soyadı zorunludur")]
     
        public string? UserSurname { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
