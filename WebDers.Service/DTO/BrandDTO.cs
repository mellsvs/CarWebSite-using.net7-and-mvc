using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDers.Service.Models;


namespace WebDers.Service.Models
{
    public class BrandDTO
    {
        [Key]
        public int BrandID { get; set; }
        [Required]
        [DisplayName("Model")]
        public string BrandName { get; set; }
        [Required]
        [DisplayName("Fiyat")]
        public int BrandPrice { get; set; }
        [Required]
        [DisplayName("Yıl")]
        public int BrandYear { get; set; }
        //public ICollection<Siparis> Sipariss { get; set; }
        [DisplayName("Marka")]
        public int ArabaMarkaID { get; set; }
    public string? ArabaMarkaName { get; set; }
        public List<ArabaMarka> ?ArabaMarkaList { get; set; }

    }
}
