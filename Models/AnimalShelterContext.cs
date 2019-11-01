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
                new ShelterList
                {
                    AnimalId = 1,
                    Name = "Carla",
                    AnimalType = "Alpaca",
                    Breed = "Suri",
                    Gender = "Female",
                    Age = 2,
                    KennelNumber = "7E",
                    Description = "Carla is sassy and love big Open spaces. She is the leader of the group."
                },

                new ShelterList
                {
                    AnimalId = 2,
                    Name = "Ruddy",
                    AnimalType = "Caiman",
                    Breed = "Cuvier's dwarf",
                    Gender = "Male",
                    Age = 8,
                    KennelNumber = "1R",
                    Description = "He may be small, but Ruddy is feisty. Watch your fingers!"
                },
                
                new ShelterList
                {
                    AnimalId = 3,
                    Name = "Sticky",
                    AnimalType = "Frog",
                    Breed = "Tomato",
                    Gender = "Male",
                    Age = 1,
                    KennelNumber = "5A",
                    Description = "He's a  frog. He does froggy things. He loves the hand taxi. Will do a heckin' monch before trusting hand taxi."
                }
            );
        }
    }
}