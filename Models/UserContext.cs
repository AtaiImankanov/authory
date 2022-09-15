using Lab.Models;
using Microsoft.EntityFrameworkCore;

namespace Authory.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role { Id = 1, Name = "Admin" });
            modelBuilder.Entity<Role>().HasData(new Role { Id = 2, Name = "User" });
            modelBuilder.Entity<User>().HasData(new User { Id = 1, Email = "admin@admin.ad",Password="admin123",RoleId=1 });


        }

        public DbSet<Lab.Models.Order> Order { get; set; }
    }
}
