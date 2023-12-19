using Microsoft.EntityFrameworkCore;
using OnlineShop.Model;
//using OnlineShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OnlineShop.DAL
{
    public class OnlineShopcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;initial catalog = OnlineShopDB;encrypt=false");
        }
        public OnlineShopcontext(DbContextOptions option) : base(option) { }    
        public DbSet<Product>products { get; set; }

    }
}