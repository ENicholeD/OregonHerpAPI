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
                    Age = "Young",
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
                    Age = "Teen",
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
                    Age = "Young",
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
                    Age = "Young",
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
                    Age = "Teen",
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
                    Age = "Young",
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
                    Age = "Adult",
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
                    Age = "Teen",
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
                    Age = "Young",
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
                    Age = "Adult",
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
                    Age = "Adult",
                    KennelNumber = "5D",
                    Description = "Borneo is smaller than he should be. He acts like a puppy dog, even loves playing catch."
                },
                new ShelterList
                {
                    ShelterListId = 12,
                    Name = "Falcore",
                    PhotoPath = "wwwroot/uploads/Flacore.jpg",
                    AnimalType = "Dragon",
                    Breed = "Luck Dragon",
                    Gender = "Male",
                    Age = "???",
                    KennelNumber = "7H",
                    Description = "You mean... We have THE Falcore?! Falcore from the Never Ending Story?!"
                },
                new ShelterList
                {
                    ShelterListId = 13,
                    Name = "Rockita",
                    PhotoPath = "wwwroot/uploads/Rockita.jpg",
                    AnimalType = "Rock",
                    Breed = "Rock",
                    Gender = "None",
                    Age = "Ancient",
                    KennelNumber = "1A",
                    Description = "Um... it's... a rock."
                },
                new ShelterList
                {
                    ShelterListId = 14,
                    Name = "Cutie",
                    PhotoPath = "wwwroot/uploads/Cutie.jpg",
                    AnimalType = "Plant",
                    Breed = "Lithop",
                    Gender = "None",
                    Age = "Young",                    KennelNumber = "2A",
                    Description = "The cutest little plant on planet earth! Just look at all that cuteness!"
                },
                new ShelterList
                {
                    ShelterListId = 15,
                    Name = "Jumpy",
                    PhotoPath = "wwwroot/uploads/Jumpy.jpg",
                    AnimalType = "Spider",
                    Breed = "Bold Jumper",
                    Gender = "Female",
                    Age = "Elder",
                    KennelNumber = "1C",
                    Description = "Jumpy's eyes are very mesmerizing! We can't look away."
                },
                new ShelterList
                {
                    ShelterListId = 16,
                    Name = "Brad Person",
                    PhotoPath = "wwwroot/uploads/Brad_Person.jpg",
                    AnimalType = "Human",
                    Breed = "Nerd",
                    Gender = "Male",
                    Age = "Adult",
                    KennelNumber = "Office",
                    Description = "Hey! Guys, This ain't funny! Take this down!"
                },
                new ShelterList
                {
                    ShelterListId = 17,
                    Name = "Mist",
                    PhotoPath = "wwwroot/uploads/Misty.jpg",
                    AnimalType = "Dog",
                    Breed = "Australian Shepherd",
                    Gender = "Female",
                    Age = "Young",
                    KennelNumber = "4D",
                    Description = "Misty is Very active and very loyal. Her previous owner gaver her up because Misty didn't want to hurt the sheep."
                },
                new ShelterList
                {
                    ShelterListId = 87,
                    Name = "Xander",
                    PhotoPath = "wwwroot/uploads/Xander.jpg",
                    AnimalType = "Cat",
                    Breed = "Japanese Bontail",
                    Gender = "Male",
                    Age = "young",
                    KennelNumber = "3C",
                    Description = "Xander is very vocal an loves to play. He still has his kitten energy and will need lot of play."
                }
            );
        }
    }
}