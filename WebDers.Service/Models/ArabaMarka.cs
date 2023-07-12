using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDers.Service.Models
{
    public class ArabaMarka
    {
        [Key]
        [DisplayName("Araba Marka ")]
        public int ArabaMarkaID { get; set; }
        [Required]
        [DisplayName("Araba Markasını Giriniz") ]
        public string? ArabaMarkaName { get; set; }
        public ICollection<Brand> Brands { get; set; }
            
    }
}
