using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter_Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShelterList",
                columns: table => new
                {
                    ShelterListId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    PhotoPath = table.Column<string>(nullable: false),
                    AnimalType = table.Column<string>(maxLength: 20, nullable: false),
                    Breed = table.Column<string>(maxLength: 30, nullable: false),
                    Gender = table.Column<string>(maxLength: 30, nullable: false),
                    Age = table.Column<string>(nullable: false),
                    KennelNumber = table.Column<string>(maxLength: 15, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShelterList", x => x.ShelterListId);
                });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 1, "Young", "Alpaca", "Suri", "Carla is sassy and loves big Open spaces. She is the leader of the al-Pack-as.", "Female", "7E", "Carla", "wwwroot/uploads/Carla.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 16, "Adult", "Human", "Nerd", "Hey! Guys, This ain't funny! Take this down!", "Male", "Office", "Brad Person", "wwwroot/uploads/Brad_Person.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 15, "Elder", "Spider", "Bold Jumper", "Jumpy's eyes are very mesmerizing! We can't look away.", "Female", "1C", "Jumpy", "wwwroot/uploads/Jumpy.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 14, "Young", "Plant", "Lithop", "The cutest little plant on planet earth! Just look at all that cuteness!", "None", "2A", "Cutie", "wwwroot/uploads/Cutie.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 13, "Ancient", "Rock", "Rock", "Um... it's... a rock.", "None", "1A", "Rockita", "wwwroot/uploads/Rockita.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 12, "???", "Dragon", "Luck Dragon", "You mean... We have THE Falcore?! Falcore from the Never Ending Story?!", "Male", "7H", "Falcore", "wwwroot/uploads/Flacore.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 11, "Adult", "Elephant", "Borneo Elephant", "Borneo is smaller than he should be. He acts like a puppy dog, even loves playing catch.", "Male", "5D", "Stompers", "wwwroot/uploads/Stompers.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 10, "Adult", "Cougar", "Cougar", "We aren't sure how we got Tom, but she seems friendly.", "Female", "7V", "Tom", "wwwroot/uploads/Tom.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 9, "Young", "Fish", "Paedocypris progenetica", "So tiny, you can barely see her. Blubbles Just likes doing her own thing.", "Female", "2F", "Blubbles", "wwwroot/uploads/Blub.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 8, "Teen", "Crab", "Chesapeake blue Crab", "Always Angry.", "Male", "3F", "Crab", "wwwroot/uploads/Crab.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 7, "Adult", "Monkey", "Emperor Tamerin", "King Arthor believes He is king of all animals. Will steal your heart and your Acai fruit.", "Male", "7G", "King Arthor", "wwwroot/uploads/Toad.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 6, "Young", "Bird", "Red Factor Canary", "Loves heavy metal music. You must give him the seed or he will fight you.", "Male", "1B", "Blood", "wwwroot/uploads/Blood.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 5, "Teen", "Cat", "Ragdoll", "Raggedy Anne is a very relaxed. Her favorite pastime is sleeping and getting attention.", "Female", "3B", "Raggedy Anne", "wwwroot/uploads/Anne.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 4, "Young", "Dog", "Chinese Crested", "Toad is a fashionista. If she isn't wearing a cute outfit, she shakes uncontrollably from her naked rage.", "Female", "3D", "Toad", "wwwroot/uploads/King.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 3, "Young", "Frog", "Tomato", "He's a  frog. He does froggy things. He loves the hand taxi. Will do a heckin' monch before trusting hand taxi.", "Male", "5A", "Sticky", "wwwroot/uploads/Sticky.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 2, "Teen", "Caiman", "Cuvier's dwarf", "He may be small, but Ruddy is feisty. Watch your fingers!", "Male", "1R", "Ruddy", "wwwroot/uploads/Ruddy.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 17, "Young", "Dog", "Australian Shepherd", "Misty is Very active and very loyal. Her previous owner gaver her up because Misty didn't want to hurt the sheep.", "Female", "4D", "Mist", "wwwroot/uploads/Misty.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 87, "young", "Cat", "Japanese Bontail", "Xander is very vocal an loves to play. He still has his kitten energy and will need lot of play.", "Male", "3C", "Xander", "wwwroot/uploads/Xander.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShelterList");
        }
    }
}
