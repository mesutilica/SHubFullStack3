using Microsoft.EntityFrameworkCore;

namespace NetCoreMVCEgitimi.Models
{
    public class UyeContext : DbContext
    {        
        public DbSet<Uye> Uyeler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=UyeDb; Trusted_Connection=True;"); // sql server bağlantısı
            base.OnConfiguring(optionsBuilder);
        }
    }
}
