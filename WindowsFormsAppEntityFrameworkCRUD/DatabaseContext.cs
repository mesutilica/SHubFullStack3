using System.Data.Entity;
using WindowsFormsAppAdoNetCRUD; // entity framework kullanabilmek için gerekli

namespace WindowsFormsAppEntityFrameworkCRUD
{
    internal class DatabaseContext : DbContext // DbContext sınıfı entity framework paketiyle birlikte gelir.
    {
        public virtual DbSet<Category> Categories { get; set; } // dbset tanımlayarak veritabanındaki tabloları sembolize ediyoruz
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
