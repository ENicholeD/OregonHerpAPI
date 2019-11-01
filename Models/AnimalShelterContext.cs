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
                    Description = "Carla is sassy and loves big Open spaces. She is the leader of the al-Pack-as."
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
                    PhotoPath = "wwwroot/uploads/King.jpg",
                    AnimalType = "Dog",
                    Breed = "Chinese Crested",
                    Gender = "Female",
                    Age = 1,
                    KennelNumber = "3D",
                    Description = "Toad is a fashionista. If she isn't wearing a cute outfit, she shakes uncontrollably from her naked rage."
                },
                
                new ShelterList
                {
                    ShelterListId = 5,
                    Name = "Raggedy Anne",
                    PhotoPath = "wwwroot/uploads/Anne.jpg",
                    AnimalType = "Cat",
                    Breed = "Ragdoll",
                    Gender = "Female",
                    Age = 3,
                    KennelNumber = "3B",
                    Description = "Raggedy Anne is a very relaxed. Her favorite pastime is sleeping and getting attention."
                },
                new ShelterList
                {
                    ShelterListId = 6,
                    Name = "Blood",
                    PhotoPath = "wwwroot/uploads/Blood.jpg",
                    AnimalType = "Bird",
                    Breed = "Red Factor Canary",
                    Gender = "Male",
                    Age = 1,
                    KennelNumber = "1B",
                    Description = "Loves heavy metal music. You must give him the seed or he will fight you."
                },
                new ShelterList
                {
                    ShelterListId = 7,
                    Name = "King Arthor",
                    PhotoPath = "wwwroot/uploads/Toad.jpg",
                    AnimalType = "Monkey",
                    Breed = "Emperor Tamerin",
                    Gender = "Male",
                    Age = 12,
                    KennelNumber = "7G",
                    Description = "King Arthor believes He is king of all animals. Will steal your heart and your Acai fruit."
                },
                new ShelterList
                {
                    ShelterListId = 8,
                    Name = "Crab",
                    PhotoPath = "wwwroot/uploads/Crab.jpg",
                    AnimalType = "Crab",
                    Breed = "Chesapeake blue Crab",
                    Gender = "Male",
                    Age = 5,
                    KennelNumber = "3F",
                    Description = "Always Angry."
                },
                new ShelterList
                {
                    ShelterListId = 9,
                    Name = "Blubbles",
                    PhotoPath = "wwwroot/uploads/Blub.jpg",
                    AnimalType = "Fish",
                    Breed = "Paedocypris progenetica",
                    Gender = "Female",
                    Age = 20,
                    KennelNumber = "2F",
                    Description = "So tiny, you can barely see her. Blubbles Just likes doing her own thing."
                },
                new ShelterList
                {
                    ShelterListId = 10,
                    Name = "Tom",
                    PhotoPath = "wwwroot/uploads/Tom.jpg",
                    AnimalType = "Cougar",
                    Breed = "Cougar",
                    Gender = "Female",
                    Age = 7,
                    KennelNumber = "7V",
                    Description = "We aren't sure how we got Tom, but she seems friendly."
                },
                new ShelterList
                {
                    ShelterListId = 11,
                    Name = "Stompers",
                    PhotoPath = "wwwroot/uploads/Stompers.jpg",
                    AnimalType = "Elephant",
                    Breed = "Borneo Elephant",
                    Gender = "Male",
                    Age = 15,
                    KennelNumber = "5D",
                    Description = "Borneo is smaller than he should be. He acts like a puppy dog, even loves playing catch."
                }
            );
        }
    }
}