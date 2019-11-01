using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter_Api.Migrations
{
    public partial class initial : Migration
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
                    AnimalType = table.Column<string>(maxLength: 20, nullable: false),
                    Breed = table.Column<string>(maxLength: 30, nullable: false),
                    Gender = table.Column<string>(maxLength: 30, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    KennelNumber = table.Column<string>(maxLength: 15, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShelterList", x => x.ShelterListId);
                });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name" },
                values: new object[] { 1, 2, "Alpaca", "Suri", "Carla is sassy and love big Open spaces. She is the leader of the group.", "Female", "7E", "Carla" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name" },
                values: new object[] { 2, 8, "Caiman", "Cuvier's dwarf", "He may be small, but Ruddy is feisty. Watch your fingers!", "Male", "1R", "Ruddy" });

            migrationBuilder.InsertData(
                table: "ShelterList",
                columns: new[] { "ShelterListId", "Age", "AnimalType", "Breed", "Description", "Gender", "KennelNumber", "Name" },
                values: new object[] { 3, 1, "Frog", "Tomato", "He's a  frog. He does froggy things. He loves the hand taxi. Will do a heckin' monch before trusting hand taxi.", "Male", "5A", "Sticky" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShelterList");
        }
    }
}
