using Microsoft.EntityFrameworkCore.Migrations;

namespace OregonHerp_Api.Migrations
{
    public partial class Initial : Migration
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
                values: new object[] { 1, "Tiger salamaders are loyal to where they were born and will travel long distances to return. They have only a 50% chance of breeding more than once in their lifetime and only breed in the later winter and early spring months. After about 48 hours after insemination, the female will lay her eggs in the breeding pool, attaching them to secure places to ensure their safety. Their larvae are entirely aquatic with external gills and a prominent caudal fin, similar to Axolotls.In certain cases, where the weather is warmer, they may not metamorphose until they are adult size. They also have been known to never metamorphose and stay in their larva stage their entire lives and reach sexual maturity while in their larva form.", "Amphibian", "Tiger Salamander", "Least     Concern", "Brown or black bodies with either brownish-yellow or greenish yellow spots on their heads, bodies, and tails.", "Insects, earthworms, grubs, small snails, slugs, minnows, other amphibians (in rare cases, other tiger salamanders), crustacians (while in their larva form).", "Although immune, tiger salamaders transmit amphibian chytrid fungus which causes Chytridiomycosis which affects amphibians worldwide. They also carry ranaviruses which infects reptiles, amphibians, and fish, and has been linked to high mortality in tiger salamander larvae when there's reoccuring ranavirus infections.", "Wetlands, rivers and streams. They are mostly terrestrial, only returning to the water to breed.", false, "12-15 years", "../wwwroot/uploads/tigerSalamander.jpg", "Racoons, Coatis, river turtles, garter snakes, small mammals, birds, fish.", "Ambystoma tigrinum", "15-20 cm" });

            migrationBuilder.InsertData(
                table: "HerpList",
                columns: new[] { "HerpListId", "Breeding", "Classification", "CommonName", "ConservationStatus", "Description", "Diet", "Diseases", "Habitat", "InvasiveStatus", "Lifespan", "PhotoPath", "Predators", "ScientificName", "Size" },
                values: new object[] { 2, "Northwestern Salamanders breed in low-elevation sites during June to late August after migrating to breeding sites between January and April. They become sexually mature at 1-2 years of age. Their breeding occures in permanent and semi-permanent lakes, ponds, wetlands, and slow flowing rivers and streams, even if ice is still present. Males will often arrive before females, and the breading season lasts aproximately 1-7 weeks, which is dependant on the temperature increase rate of the water.Females lay about 30-270 eggs, if they are fully metamorphosed, in masses about the size of an orange, atatching them to secure locations underwater. If the female is not fully metamorphosed, she will lay a much smaller clutch, and leave them at the bottom of the pond or lake. Eggs will become covered in algae, which helps the developing embryo breathe.", "Amphibian", "Northwestern Salamander", "Least Concern", "Dark brown, gray, or black.", "Small invertebrates, aquatic invertebrates, tadpoles, snails, worms, fairy shrimp.", "Could cause sickness in humans if ingested due to their poisonous skin secretions.", "Moist habitats such as open grasslands, forests, and woodlands withe nearby freshwater sources.", false, "5 years", "../wwwroot/uploads/northwesternSalamander.jpg", "Predatory fish, Rough-skinned newts (often seen eating their eggs), garter snakes, small mammals, birds, fish.", "Ambystoma gracile", "4-10.7 cm" });

            migrationBuilder.InsertData(
                table: "HerpList",
                columns: new[] { "HerpListId", "Breeding", "Classification", "CommonName", "ConservationStatus", "Description", "Diet", "Diseases", "Habitat", "InvasiveStatus", "Lifespan", "PhotoPath", "Predators", "ScientificName", "Size" },
                values: new object[] { 3, "Breeding ranges from January to July, and can be found in groups under natural debris near the edges of the water, especially in April and May. They lay their eggs near the shore lines of ponds and slow moving streams. They will either lay the eggs individually or in bunches in secure places underwater.", "Amphibian macrodactylum", "Long-Toed Salamander", "Least Concern", "Dark body with a tan/yellowish/greenish stripe along its back. Their belly is dark with small white speckles. They have one long toe on their back feet (hence the name).", "Slugs, worms, instect, frog tadpoles, smaller salamander larvae.  For larvae, they eat zooplankton.", "Secrets a milky concoction from its tail when  threatened that is noxious, and possibly poisonous.", "Moist vegitation near water in forests, prairies or mountain meadows, occasionally in human trafficed areas.", false, "7 years", "../wwwroot/uploads/Long-toedSalamander.jpg", "Garter snakes, small mammals, birds, fish", "Ambystoma ", "4-9 cm" });

            migrationBuilder.InsertData(
                table: "HerpList",
                columns: new[] { "HerpListId", "Breeding", "Classification", "CommonName", "ConservationStatus", "Description", "Diet", "Diseases", "Habitat", "InvasiveStatus", "Lifespan", "PhotoPath", "Predators", "ScientificName", "Size" },
                values: new object[] { 4, "They lay around 50-115 eggs in their wet environment, and maybe gaurds them aggressively.", "Amphibian", "Cope's Giant Salamander", "Least Concern", "marbled gold brown, costal grooves, latterally compressed tail. Metamorphosed forms are rare. Not much is known of the Cope's Giant Salamander.", "fish, amphibians, amphibian eggs (including their own).", null, "Clear mountain streams in damp forests.", false, null, "../wwwroot/uploads/copesGiantSalamander.jpg", "Garter Snakes, water shrew.", "Dicamptodon copei", "19.5 cm" });

            migrationBuilder.InsertData(
                table: "HerpList",
                columns: new[] { "HerpListId", "Breeding", "Classification", "CommonName", "ConservationStatus", "Description", "Diet", "Diseases", "Habitat", "InvasiveStatus", "Lifespan", "PhotoPath", "Predators", "ScientificName", "Size" },
                values: new object[] { 5, null, "Amphibian", "Coastal Giant Salamander", "Least Concern", "light brown or brass-colored skin with dark marbled or reticulated blotched pattern. They are one of the few salamanders capable of vocalizing.", "Larvae will consume insects, insect larvae, amphipods, ostracods, termatoes, molusks, crayfish, eggs. Adults will eat small mammals, snakes, amphibians, fish, other marine invertebrates.", null, "Small to midsize streams and moist riverside forests with Gravel to small-boulder covered stream beds. They can also be found under forest debris during rainy periods. They can be found in elevations ranging from sea level to 1830 m.", false, null, "../wwwroot/uploads/coastalGiantSalamander.jpg", "Weasels, river otters, water shrews, garter snakes, salmonids, conspecifics.", "Dicamptodon tenebrosus", "34 cm" });

            migrationBuilder.InsertData(
                table: "HerpList",
                columns: new[] { "HerpListId", "Breeding", "Classification", "CommonName", "ConservationStatus", "Description", "Diet", "Diseases", "Habitat", "InvasiveStatus", "Lifespan", "PhotoPath", "Predators", "ScientificName", "Size" },
                values: new object[] { 6, null, "Amphibian", "Columbia Torrent Salamander", "Near Threatened", "There isn't much known about this species.", null, null, "Temperate forests, rivers, and freshwater springs. Clear, cold, mountain springs.", false, null, null, null, "Rhyacotriton kezeri", "10 cm" });

            migrationBuilder.InsertData(
                table: "HerpList",
                columns: new[] { "HerpListId", "Breeding", "Classification", "CommonName", "ConservationStatus", "Description", "Diet", "Diseases", "Habitat", "InvasiveStatus", "Lifespan", "PhotoPath", "Predators", "ScientificName", "Size" },
                values: new object[] { 7, null, "Salamander", "Southern Torrent Salamander", "Least Concern", "", "", null, "", false, null, "../wwwroot/uploads/southernTorrentSalamander.jpg", "", "Rhyacotriton variegatus", "4-6.2 cm" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HerpList");
        }
    }
}
