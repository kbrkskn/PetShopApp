using Microsoft.EntityFrameworkCore;
using PetShopApp.Core.Models;
using PetShopApp.DataAccessLayer.Configurations;
using PetShopApp.DataAccessLayer.Seeds;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.DataAccessLayer
{
    public class PetShopDbContext : DbContext
    {
        public PetShopDbContext(DbContextOptions<PetShopDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Guid g1 = Guid.NewGuid();
            Guid g2 = Guid.NewGuid();
            Guid g3 = Guid.NewGuid();
            Guid g4 = Guid.NewGuid();
            Guid g5 = Guid.NewGuid();
            Guid g6 = Guid.NewGuid();
            Guid g7 = Guid.NewGuid();
            Guid g8 = Guid.NewGuid();
            Guid g9 = Guid.NewGuid();
            Guid g10 = Guid.NewGuid();
            Guid g11 = Guid.NewGuid();
            Guid g12 = Guid.NewGuid();
            Guid g13 = Guid.NewGuid(); 
            Guid g14 = Guid.NewGuid();
            Guid g15 = Guid.NewGuid();
            Guid g16 = Guid.NewGuid();
            Guid g17 = Guid.NewGuid();
            Guid g18 = Guid.NewGuid();
            Guid g19 = Guid.NewGuid();
            Guid g20 = Guid.NewGuid();
            Guid g21 = Guid.NewGuid();
            Guid g22 = Guid.NewGuid();
            Guid g23 = Guid.NewGuid();
            Guid g24 = Guid.NewGuid();


            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new SubCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductFeatureConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            //modelBuilder.ApplyConfiguration(new OrderConfiguration());



            modelBuilder.ApplyConfiguration(new CategorySeed(new Guid[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23, g24 }));
            modelBuilder.ApplyConfiguration(new SubCategorySeed(new Guid[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23, g24 }));
            modelBuilder.ApplyConfiguration(new ProductSeed(new Guid[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23, g24 }));
            modelBuilder.ApplyConfiguration(new ProductFeatureSeed(new Guid[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23, g24 }));
            modelBuilder.ApplyConfiguration(new UserSeed(new Guid[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23, g24 }));
            modelBuilder.ApplyConfiguration(new CommentSeed(new Guid[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23, g24 }));
        }

    }
}
