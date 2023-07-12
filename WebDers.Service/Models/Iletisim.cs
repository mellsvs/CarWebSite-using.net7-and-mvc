using System.ComponentModel.DataAnnotations;

namespace WebDers.Service.Models
{
    public class Iletisim
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string AdSoyad { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]

        public string Konu { get; set; }
        [Required]
        public string Mesaj { get; set; }
    }
}
