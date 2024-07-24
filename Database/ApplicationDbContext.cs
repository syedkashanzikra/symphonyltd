using Microsoft.EntityFrameworkCore;
using SymphonyLtd.Models;
using SymphonyLtd.ViewModels;

namespace SymphonyLtd.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<users> users { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<contact> tblContact { get; set; }

        public DbSet<courses> tblCourses { get; set; }
        public DbSet<students> tblStudents { get; set; }

        public DbSet<SymphonyLtd.ViewModels.LoginViewModel> LoginViewModel { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<users>().HasData(
                new users { Id = 1, Name = "Admin One", Email = "admin1@example.com", Password = "password1", RememberToken = "token1", Role = "Admin", PhoneNumber = "1234567890" },
                new users { Id = 2, Name = "Admin Two", Email = "admin2@example.com", Password = "password2", RememberToken = "token2", Role = "Admin", PhoneNumber = "0987654321" },
                new users { Id = 3, Name = "User One", Email = "user1@example.com", Password = "password3", RememberToken = "token3", Role = "User", PhoneNumber = "1111111111" },
                new users { Id = 4, Name = "User Two", Email = "user2@example.com", Password = "password4", RememberToken = "token4", Role = "User", PhoneNumber = "2222222222" },
                new users { Id = 5, Name = "User Three", Email = "user3@example.com", Password = "password5", RememberToken = "token5", Role = "User", PhoneNumber = "3333333333" }
            );
        }
    }
}
