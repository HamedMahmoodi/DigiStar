using Microsoft.EntityFrameworkCore;

using SuperMarket.DataLayer.Entites.Order;
using SuperMarket.DataLayer.Entites.Product;
using SuperMarket.DataLayer.Entites.User;
using SuperMarket.DataLayer.Entites.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperMarket.DataLayer.Context
{
    public class SuperMarketContext : DbContext
    {
        public SuperMarketContext(DbContextOptions<SuperMarketContext> options) : base(options)
        {

        }

        #region User

        public DbSet<User> Users { get; set; }
        public DbSet<UserDiscountCode> UserDiscountCodes { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }

        #endregion

        #region Wallet

        public DbSet<WalletType> WalletTypes { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

        #endregion

        #region Product

        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<ProductStatus> ProductStatuses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserProduct> UserProducts { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }

        #endregion

        #region Order

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Discount> Discounts { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
               .SelectMany(t => t.GetForeignKeys())
               .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDelete);

            modelBuilder.Entity<Product>()
                .HasQueryFilter(p => !p.IsDelete);

            modelBuilder.Entity<ProductGroup>()
                .HasQueryFilter(g => !g.IsDelete);

            modelBuilder.Entity<Discount>()
                .HasQueryFilter(d => !d.IsDelete);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductGroup)
                .WithMany(b => b.Products)
              .HasForeignKey(f => f.GroupId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Group)
                .WithMany(b => b.SubGroup)
                .HasForeignKey(f => f.SubGroup);



            base.OnModelCreating(modelBuilder);
        }
    }
}
