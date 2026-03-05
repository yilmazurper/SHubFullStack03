using System.Data.Entity;
using System.Management.Instrumentation;
using WindowsFormsAppAdonetCRUD; //entity framework kullanabbilmek icin gerekli 

namespace WindowsFormsAppEntityFrameworkCRUD
{
    internal class DatabaseContext : DbContext // DbContext sinifi entity framework paketiyle birlikte gelir 
    {
        public virtual DbSet <Category>Categories{ get; set; } //Dbset tanimlayarak veritabanindaki tablolari sembolize ediyouruz
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
       
    }
}
