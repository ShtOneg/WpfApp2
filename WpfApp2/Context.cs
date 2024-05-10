using Microsoft.EntityFrameworkCore;

namespace WpfApp2
{
    public class Context : DbContext
    {
        public DbSet<Eat> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=products.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Eat>().HasData(
                new Eat { EatId = 0, Count = 2, Description = "ddd", Name = "lo", Type = "milk" }
                );
        }
    }
}
