using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebDers.Service.Models
{
    public class CarBlog
    {
        [Key]
        public int CarBlogID { get; set; }
        [Required]
        [DisplayName("Başlik")]
        public string CarBlogTittle { get; set; }
        [Required]
        [DisplayName("Icerik")]
        public string CarBlogDescription { get; set; }
        [Required]
        [DisplayName("Resim")]
        public string CarBlogImage { get; set; }
        [Required]
        [DisplayName("Tarih")]
        public DateTime CarBlogDate { get; set; }
    
    }
}
