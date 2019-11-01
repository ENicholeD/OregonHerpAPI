using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter_Api.Migrations
{
    public partial class moreAnimals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 1,
                column: "Description",
                value: "Carla is sassy and loves big Open spaces. She is the leader of the al-Pack-as.");

            migrationBuilder.UpdateData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 2,
                column: "PhotoPath",
                value: "wwwroot/uploads/Ruddy.jpg");

            migrationBuilder.UpdateData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 3,
                column: "PhotoPath",
                value: "wwwroot/uploads/Sticky.jpg");

            migrationBuilder.UpdateData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 4,
                column: "PhotoPath",
                value: "wwwroot/uploads/King.jpg");

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 5, 3, "Cat", "Ragdoll", "Raggedy Anne is a very relaxed. Her favorite pastime is sleeping and getting attention.", "Female", "3B", "Raggedy Anne", "wwwroot/uploads/Anne.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 6, 1, "Bird", "Red Factor Canary", "Loves heavy metal music. You must give him the seed or he will fight you.", "Male", "1B", "Blood", "wwwroot/uploads/Blood.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 7, 12, "Monkey", "Emperor Tamerin", "King Arthor believes He is king of all animals. Will steal your heart and your Acai fruit.", "Male", "7G", "King Arthor", "wwwroot/uploads/Toad.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 8, 5, "Crab", "Chesapeake blue Crab", "Always Angry.", "Male", "3F", "Crab", "wwwroot/uploads/Crab.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 9, 20, "Fish", "Paedocypris progenetica", "So tiny, you can barely see her. Blubbles Just likes doing her own thing.", "Female", "2F", "Blubbles", "wwwroot/uploads/Blub.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 10, 7, "Cougar", "Cougar", "We aren't sure how we got Tom, but she seems friendly.", "Female", "7V", "Tom", "wwwroot/uploads/Tom.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 11, 15, "Elephant", "Borneo Elephant", "Borneo is smaller than he should be. He acts like a puppy dog, even loves playing catch.", "Male", "5D", "Stompers", "wwwroot/uploads/Stompers.jpg" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 12, 175, "Dragon", "Luck Dragon", "You mean... We have THE Falcore?! Falcore from the Never Ending Story?!", "Male", "7H", "Falcore", "wwwroot/uploads/Flacore.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 1,
                column: "Description",
                value: "Carla is sassy and love big Open spaces. She is the leader of the group.");

            migrationBuilder.UpdateData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 2,
                column: "PhotoPath",
                value: "wwwroot/uploads/Carla.jpg");

            migrationBuilder.UpdateData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 3,
                column: "PhotoPath",
                value: "wwwroot/uploads/Carla.jpg");

            migrationBuilder.UpdateData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 4,
                column: "PhotoPath",
                value: "wwwroot/uploads/Carla.jpg");
        }
    }
}
