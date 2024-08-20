using Microsoft.EntityFrameworkCore;
using SimpleWebApp.Models;

namespace SimpleWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Person> Person_Info { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "Antony Fetucini", Age = "50", BirthDate = new DateOnly(1950, 1, 1), Address = "123 William Street, Melbourne VIC 6969, Australia", Phone ="012345678" },
                new Person { Id = 2, Name = "Felipa Fetucini", Age = "49", BirthDate = new DateOnly(1960, 2, 1), Address = "123 William Street, Melbourne VIC 6969, Australia", Phone = "012345678" },
                new Person { Id = 3, Name = "Androzy Fetucini", Age = "23", BirthDate = new DateOnly(1990, 9, 30), Address = "123 William Street, Melbourne VIC 6969, Australia", Phone = "012345678" }
                );
        }
    }
}
