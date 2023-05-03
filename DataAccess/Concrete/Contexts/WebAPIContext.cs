using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Contexts
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext(DbContextOptions<WebAPIContext> options) : base(options)
        {

        }
        public WebAPIContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = @"Data Source=ASEN\SQLEXPRESS;Initial Catalog=Yoklama;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }
}
