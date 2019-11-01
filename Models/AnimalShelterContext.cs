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
                    ShelterListId = 1,
                    Name = "Carla",
                    PhotoPath = "wwwroot/uploads/Carla.jpg",
                    AnimalType = "Alpaca",
                    Breed = "Suri",
                    Gender = "Female",
                    Age = 2,
                    KennelNumber = "7E",
                    Description = "Carla is sassy and love big Open spaces. She is the leader of the group."
                },

                new ShelterList
                {
                    ShelterListId = 2,
                    Name = "Ruddy",
                    PhotoPath = "wwwroot/uploads/Ruddy.jpg",
                    AnimalType = "Caiman",
                    Breed = "Cuvier's dwarf",
                    Gender = "Male",
                    Age = 8,
                    KennelNumber = "1R",
                    Description = "He may be small, but Ruddy is feisty. Watch your fingers!"
                },
                
                new ShelterList
                {
                    ShelterListId = 3,
                    Name = "Sticky",
                    AnimalType = "Frog",
                    PhotoPath = "wwwroot/uploads/Sticky.jpg",
                    Breed = "Tomato",
                    Gender = "Male",
                    Age = 1,
                    KennelNumber = "5A",
                    Description = "He's a  frog. He does froggy things. He loves the hand taxi. Will do a heckin' monch before trusting hand taxi."
                },
                new ShelterList
                {
                    ShelterListId = 4,
                    Name = "Toad",
                    PhotoPath = "wwwroot/uploads/Toad.jpg",
                    AnimalType = "Dog",
                    Breed = "Chinese Crested",
                    Gender = "Female",
                    Age = 1,
                    KennelNumber = "3D",
                    Description = "Toad is a fashionista. If she isn't wearing a cute outfit, she shakes uncontrollably from her naked rage."
                }
            );
        }
    }
}