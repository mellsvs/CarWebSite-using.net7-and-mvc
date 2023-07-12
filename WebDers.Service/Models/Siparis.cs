using System.ComponentModel.DataAnnotations;

namespace WebDers.Service.Models
{
    public class Siparis
    {
        [Key]
        public int SiparisID { get; set; }
        
        public int BrandID { get; set; }
        public  Brand Brand { get; set; }
        public int UserID { get; set; }
      public User User { get; set; }
    }
}
