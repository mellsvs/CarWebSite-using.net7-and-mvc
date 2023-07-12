using Microsoft.EntityFrameworkCore;
using WebDers.Service.Models;

namespace WebDers.Service.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base (options)
        {
            
        }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<CarBlog> CarBlogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Siparis> Sipariss { get; set; }
        public DbSet<User> Users { get; set; }
        
  
        public DbSet<ArabaMarka>ArabaMarkas { get; set; }
       
        
        
    
    }
}
