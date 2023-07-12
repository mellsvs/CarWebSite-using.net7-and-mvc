using System.ComponentModel.DataAnnotations;

namespace WebDers.Service.Models
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FotoUrl { get; set; }
        [Required]
        public string Aciklama { get; set; }
    }
}
