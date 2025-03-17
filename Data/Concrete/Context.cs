using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Data.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server = LENOVO\\SQLEXPRESS; Database = RoRoDatabase; Trusted_Connection = True;");
        }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Fleet> Fleets { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<AboutUs> AboutUss { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Expertice> Expertices { get; set; }

    }
}