using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>().HasData(
                new Value { Id = 1, Name = "Value 0001" },
                new Value { Id = 2, Name = "Value 0002" },
                new Value { Id = 3, Name = "Value 0003" },
                new Value { Id = 4, Name = "Value 0004" },
                new Value { Id = 5, Name = "Value 0005" }
            );
        }
    }
}