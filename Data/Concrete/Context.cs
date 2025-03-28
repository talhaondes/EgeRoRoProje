using Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data.Concrete
{
    public class Context : IdentityDbContext<ApplicationUser>
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Crew> Crews { get; set; }
        public DbSet<Fleet> Fleets { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<AboutUs> AboutUss { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Expertice> Expertices { get; set; }

    }
}