using vidly.Models;
using Microsoft.EntityFrameworkCore;

namespace vidly.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) 
        : base(options) {}
        public DbSet<Movie> movies { get; set; } 
        public DbSet<Customer> customers { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>(entity => entity.Property(m => m.Id).HasMaxLength(255));
            modelBuilder.Entity<Customer>(entity => entity.Property(m => m.Id).HasMaxLength(255));
        }
    }
}