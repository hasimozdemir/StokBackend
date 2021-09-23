using Microsoft.EntityFrameworkCore;
using StokEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokEntity.Context
{
    public class OrnekVeriDbContext : DbContext
    {
        public OrnekVeriDbContext()
        {
        }

        public OrnekVeriDbContext(DbContextOptions<OrnekVeriDbContext> options) : base(options)
        {//Context - Data altına , Models-Data altına , 

        }
       
        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categorys { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);//one to many ilişkisi 
            modelBuilder.Entity<Product>()
                .HasOne(e => e.Category)
                .WithMany(c => c.Products);

            
        }
        public DbSet<StokEntity.Models.ProductDTO> ProductDTO { get; set; }

    }
   
}

