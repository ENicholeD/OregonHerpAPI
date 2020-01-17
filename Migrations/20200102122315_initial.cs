using Microsoft.EntityFrameworkCore.Migrations;

namespace OregonHerp_Api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HerpList",
                columns: table => new
                {
                    HerpListId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ScientificName = table.Column<string>(nullable: false),
                    CommonName = table.Column<string>(nullable: true),
                    Classification = table.Column<string>(nullable: true),
                    PhotoPath = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    Habitat = table.Column<string>(nullable: false),
                    Breeding = table.Column<string>(nullable: true),
                    Diet = table.Column<string>(nullable: true),
                    Lifespan = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    ConservationStatus = table.Column<string>(nullable: true),
                    Diseases = table.Column<string>(nullable: true),
                    Predators = table.Column<string>(nullable: true),
                    InvasiveStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HerpList", x => x.HerpListId);
                });

            migrationBuilder.InsertData(
                table: "HerpList",
                columns: new[] { "HerpListId", "Breeding", "Classification", "CommonName", "ConservationStatus", "Description", "Diet", "Diseases", "Habitat", "InvasiveStatus", "Lifespan", "PhotoPath", "Predators", "ScientificName", "Size" },
                values: new object[] { 1, "Tiger salamaders are loyal to where they were born and will travel long distances to return. They have only a 50% chance of breeding more than once in their lifetime and only breed in the later winter and early spring months. This is aproximately when the ground is warmer and the water has thawed. After nudging a willing female, the male will deposite a spermatophore on the lake bottom. After about 48 hours after insemination, the female will lay her eggs in the breeding pool, attaching them to secure places to ensure their safety. It takes Roughly 12-50 days for all of the eggs to hatch, and 3 months to fully mature into adults. Their larvae are entirely aquatic with external gills and a prominent caudal fin, similar to Axolotls. As they grow, they develope limbs shortly after hatching. In certain cases, such as with seasonal pools, they may mature faster, becoming small morph adults. In other cases where the weather is warmer and ancestral pools, they may not metamorphose until they are adult size. They also have been known to never metamorphose and stay in their larva stage their entire lives and reach sexual maturity while in their larva form.", "Amphibian", "Tiger Salamander", "Least Concern", "They are easily identified by their brown or black bodies with either brownish-yellow or greenish yellow spots on their heads, bodies, and tails.", "Insects, earthworms, grubs, small snails, slugs, minnows, other amphibians (in rare cases, other tiger salamanders), crustacians (while in their larva form).", "Although immune, tiger salamaders transmit amphibian chytrid fungus which causes Chytridiomycosis which affects amphibians worldwide. They also carry ranaviruses which infects reptiles, amphibians, and fish, and has been linked to high mortality in tiger salamander larvae when there's reoccuring ranavirus infections.", "Wetlands, rivers and streams. They are mostly terrestrial, only returning to the water to breed.", false, "12-15 years", "../wwwroot/uploads/tigerSalamander.jpg", "Racoons, Coatis, river turtles.", "Ambystoma tigrinum", "15-35 cm" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HerpList");
        }
    }
}
