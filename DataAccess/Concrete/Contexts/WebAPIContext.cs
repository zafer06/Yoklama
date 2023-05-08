using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

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
            string conString = @"Data Source=172.29.64.1,1401; User ID=sa; Password=Aa123456; Initial Catalog=Yoklama; Trusted_Connection=True; TrustServerCertificate=True; Persist Security Info=True; Integrated Security=False;";
            optionsBuilder.UseSqlServer(conString);
            //optionsBuilder.UseSqlServer(new ConfigurationBuilder().Build().GetConnectionString("YoklamaDb"));
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
