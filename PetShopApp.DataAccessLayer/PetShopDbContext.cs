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
        public DbSet<DiscountedProduct> DiscountedProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasOne(a => a.SubCategory).WithMany(a => a.Products).HasForeignKey(e => e.SubCategoryID).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Product>().HasOne(a => a.Category).WithMany(a => a.Products).HasForeignKey(e => e.CategoryID).OnDelete(DeleteBehavior.NoAction);




            int g1 = 1;
            int g2 = 2;
            int g3 = 3;
            int g4 = 4;
            int g5 = 5;
            int g6 = 6;
            int g7 = 7;
            int g8 = 8;
            int g9 = 9;
            int g10 = 10;
            int g11 = 11;
            int g12 = 12;
            int g13 = 13;
            int g14 = 14;
            int g15 = 15;
            int g16 = 16;
            int g17 = 17;
            int g18 = 18;
            int g19 = 19;
            int g20 = 20;
            int g21 = 21;
            int g22 = 22;
            int g23 = 23;
            int g24 = 24;


            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new SubCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductFeatureConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            //modelBuilder.ApplyConfiguration(new OrderConfiguration());


            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23, g24 }));
            modelBuilder.ApplyConfiguration(new SubCategorySeed(new int[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23, g24 }));
            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23, g24 }));
            modelBuilder.ApplyConfiguration(new ProductFeatureSeed(new int[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23, g24 }));
            modelBuilder.ApplyConfiguration(new UserSeed(new int[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23, g24 }));
            modelBuilder.ApplyConfiguration(new CommentSeed(new int[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23, g24 }));
        }

    }
}
