using BasicECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicECommerce.Infrastructure
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Page> Pages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Page>().HasData(
                new Page { Id = 1, Title = "Home", Slug = "home", Body = "Welcome to our store!" },
                new Page { Id = 2, Title = "About", Slug = "about", Body = "About us" },
                new Page { Id = 3, Title = "Services", Slug = "services", Body = "Services" },
                new Page { Id = 4, Title = "Contact", Slug = "contact", Body = "Contact us" }

                );
        }

    }
}
