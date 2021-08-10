using Microsoft.EntityFrameworkCore;
using Sep3Tier3.Models;

namespace Sep3Tier3.DataAccess
{
    public class sepDBContext : DbContext
    {
        public DbSet<User>Users { set; get; }
        public DbSet<Message>Messages { set; get; }
        public DbSet<Friend>Friends { set; get; }
  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = ./sep.db");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friend>()
                .HasKey(c => new { c.username1, c.username2 });
        }
        
    }
}