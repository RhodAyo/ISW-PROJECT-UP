using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UP.Areas.Identity.Data;
using UP.Models;

namespace UP.Migrations
{
    public class ApplicationDbContext : IdentityDbContext<UPUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Job> Jobs { get; set; }

        public DbSet<Training> Trainings { get; set; }

    }

}
