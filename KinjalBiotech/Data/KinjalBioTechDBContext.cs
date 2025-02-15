using KinjalBiotech.Model;
using Microsoft.EntityFrameworkCore;

namespace KinjalBiotech.API.Data
{
    public class KinjalBioTechDBContext:DbContext
    {
        public KinjalBioTechDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CategoryDetail>().HasKey(c => c.CategoryID);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductDetail>().HasKey(p => p.ProductID);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserDetail>().HasKey(u => u.UserID);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SalesDetail>().HasKey(s => s.SellID);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>().HasKey(r => r.RoleID);



        }
        public DbSet<CategoryDetail> Category { get; set; }

        public DbSet<ProductDetail> Product { get; set; }

        public DbSet<UserDetail> User { get; set; }

        public DbSet<SalesDetail> Sales { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
