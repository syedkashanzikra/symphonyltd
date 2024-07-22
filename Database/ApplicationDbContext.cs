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
    }
}
