using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }
            public DbSet<ShelterList> ShelterList { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ShelterList>().HasData(
            );
        }
    }
}