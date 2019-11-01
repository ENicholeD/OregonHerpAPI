using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter_Api.Migrations
{
    public partial class pictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "ShelterList",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 1,
                column: "PhotoPath",
                value: "wwwroot/uploads/Carla.jpg");

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

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name", "PhotoPath" },
                values: new object[] { 4, 1, "Dog", "Chinese Crested", "Toad is a fashionista. If she isn't wearing a cute outfit, she shakes uncontrollably from her naked rage.", "Female", "3D", "Toad", "wwwroot/uploads/Carla.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShelterList",
                keyColumn: "ShelterListId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "ShelterList");
        }
    }
}
