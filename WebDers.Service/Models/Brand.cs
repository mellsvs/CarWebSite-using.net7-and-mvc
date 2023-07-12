using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace WebDers.Service.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }
          public string BrandName { get; set; }
     
        public int BrandPrice { get; set; }
     
        public int BrandYear { get; set; }
        //public ICollection<Siparis> Sipariss { get; set; }
      
        public int ArabaMarkaID { get; set; }
        [ForeignKey("ArabaMarkaID")]
        public ArabaMarka ArabaMarka { get; set; }


    }
}
