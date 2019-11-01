using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter_Api.Migrations
{
    public partial class newAnimals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 87);

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 18, "young", "Cat", "Japanese Bontail", "Xander is very vocal an loves to play. He still has his kitten energy and will need lot of play.", "Male", "3C", "Xander", "wwwroot/uploads/Xander.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 19, "Puppy", "Dog", "Golden Retreiver", "The bestest boy in the whole shelter.", "Male", "8D", "Chubs", "wwwroot/uploads/Chubs.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 20, "young", "Hamster", "Black Bear Hamster", "Very Active, but not very nice to other hamsters.", "Male", "1H", "Diddy", "wwwroot/uploads/.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 21, "Teen", "Rabbit", "Mini Satin Rabbit", "Just like the actor but better. He loves the movie Blue Velvet.", "Male", "2A", "Dennis Hopper", "wwwroot/uploads/Hopper.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 22, "Elder", "Chicken", "Chicken Nugget", "He was as good in life as he is now.", "None", "5A", "Chimken", "wwwroot/uploads/Chimken.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 23, "Adult", "Chicken", "Kadaknath", "Chimken's younger brother. He's really into Bauhaus.", "Male", "4G", "Balk", "wwwroot/uploads/Balk.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 24, "Puppy", "Wolf", "Gray Wolf", "Baby wolf from Alaska.", "Male", "7I", "Woof", "wwwroot/uploads/Woof.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 24);

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 87, "young", "Cat", "Japanese Bontail", "Xander is very vocal an loves to play. He still has his kitten energy and will need lot of play.", "Male", "3C", "Xander", "wwwroot/uploads/Xander.jpg" });
        }
    }
}
