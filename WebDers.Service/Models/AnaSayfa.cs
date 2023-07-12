using System.ComponentModel.DataAnnotations;

namespace WebDers.Service.Models
{
    public class AnaSayfa
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Baslik { get; set; }
        [Required]
        public string Aciklama { get; set; }
    }
}
