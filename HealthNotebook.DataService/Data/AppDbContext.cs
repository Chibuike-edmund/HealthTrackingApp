using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HealthNotebook.Entities.DbSet;

namespace HealthNotebook.DataService.Data
{
    public class AppDbContext : IdentityDbContext
    {

        public virtual DbSet<User> Users { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

    }
}