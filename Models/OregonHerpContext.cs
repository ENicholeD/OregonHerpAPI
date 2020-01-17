using Microsoft.EntityFrameworkCore;

namespace OregonHerp.Models
{
    public class OregonHerpContext : DbContext
    {
        public OregonHerpContext(DbContextOptions<OregonHerpContext> options)
            : base(options)
        {
        }
            public DbSet<HerpList> HerpList { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<HerpList>().HasData(
            new HerpList
             {
                 HerpListId = 1,
                 ScientificName = "Ambystoma tigrinum",
                 CommonName ="Tiger Salamander",
                 Classification = "Amphibian",
                 PhotoPath = "../wwwroot/uploads/tigerSalamander.jpg",
                 Description = "Brown or black bodies with either brownish-yellow or greenish yellow spots on their heads, bodies, and tails.",
                 Habitat = "Wetlands, rivers and streams. They are mostly terrestrial, only returning to the water to breed.",
                 Breeding = "Tiger salamaders are loyal to where they were born and will travel long distances to return. They have only a 50% chance of breeding more than once in their lifetime and only breed in the later winter and early spring months. After about 48 hours after insemination, the female will lay her eggs in the breeding pool, attaching them to secure places to ensure their safety. Their larvae are entirely aquatic with external gills and a prominent caudal fin, similar to Axolotls.In certain cases, where the weather is warmer, they may not metamorphose until they are adult size. They also have been known to never metamorphose and stay in their larva stage their entire lives and reach sexual maturity while in their larva form.",
                 Diet = "Insects, earthworms, grubs, small snails, slugs, minnows, other amphibians (in rare cases, other tiger salamanders), crustacians (while in their larva form).",
                 Lifespan = "12-15 years",
                 Size = "15-20 cm",
                 ConservationStatus = "Least Concern",
                 Diseases = "Although immune, tiger salamaders transmit amphibian chytrid fungus which causes Chytridiomycosis which affects amphibians worldwide. They also carry ranaviruses which infects reptiles, amphibians, and fish, and has been linked to high mortality in tiger salamander larvae when there's reoccuring ranavirus infections.",
                 Predators = "Racoons, Coatis, river turtles, garter snakes, small mammals, birds, fish.",
                 InvasiveStatus = false
             },
            new HerpList
             {
                 HerpListId = 2,
                 ScientificName = "Ambystoma gracile",
                 CommonName = "Northwestern Salamander",
                 Classification = "Amphibian",
                 PhotoPath = "../wwwroot/uploads/northwesternSalamander.jpg",
                 Description = "Dark brown, gray, or black.",
                 Habitat = "Moist habitats such as open grasslands, forests, and woodlands withe nearby freshwater sources.",
                 Breeding = "Northwestern Salamanders breed in low-elevation sites during June to late August after migrating to breeding sites between January and April. They become sexually mature at 1-2 years of age. Their breeding occures in permanent and semi-permanent lakes, ponds, wetlands, and slow flowing rivers and streams, even if ice is still present. Males will often arrive before females, and the breading season lasts aproximately 1-7 weeks, which is dependant on the temperature increase rate of the water.Females lay about 30-270 eggs, if they are fully metamorphosed, in masses about the size of an orange, atatching them to secure locations underwater. If the female is not fully metamorphosed, she will lay a much smaller clutch, and leave them at the bottom of the pond or lake. Eggs will become covered in algae, which helps the developing embryo breathe.",
                 Diet = "Small invertebrates, aquatic invertebrates, tadpoles, snails, worms, fairy shrimp.",
                 Lifespan = "5 years",
                 Size = "4-10.7 cm",
                 ConservationStatus = "Least Concern",
                 Diseases = "Could cause sickness in humans if ingested due to their poisonous skin secretions.",
                 Predators = "Predatory fish, Rough-skinned newts (often seen eating their eggs), garter snakes, small mammals, birds, fish.",
                 InvasiveStatus = false
             },
            new HerpList
            {
                HerpListId = 4,
                ScientificName = "Ambystoma ",
                CommonName = "Long-Toed Salamander",
                Classification = "Amphibian macrodactylum",
                Description = "Dark body with a tan/yellowish/greenish stripe along its back. Their belly is dark with small white speckles. They have one long toe on their back feet (hence the name).",
                PhotoPath = "../wwwroot/uploads/Long-toedSalamander.jpg",
                Habitat = "Moist vegitation near water in forests, prairies or mountain meadows, occasionally in human trafficed areas.",
                Breeding = "Breeding ranges from January to July, and can be found in groups under natural debris near the edges of the water, especially in April and May. They lay their eggs near the shore lines of ponds and slow moving streams. They will either lay the eggs individually or in bunches in secure places underwater.",
                Diet = "Slugs, worms, instect, frog tadpoles, smaller salamander larvae.  For larvae, they eat zooplankton.",
                Lifespan = "7 years",
                Size = "4-9 cm",
                ConservationStatus = "Least Concern",
                Diseases = "Secrets a milky concoction from its tail when  threatened that is noxious, and possibly poisonous.",
                Predators = "Garter snakes, small mammals, birds, fish",
                InvasiveStatus = false
            },
            new HerpList
            {
                HerpListId = 4,
                ScientificName = "Dicamptodon copei",
                CommonName = "Cope's Giant Salamander",
                Classification = "Amphibian",
                PhotoPath = "../wwwroot/uploads/copesGiantSalamander.jpg",
                Description = "marbled gold brown, costal grooves, latterally compressed tail. Metamorphosed forms are rare. Not much is known of the Cope's Giant Salamander.",
                Habitat = "Clear mountain streams in damp forests.",
                Breeding = "They lay around 50-115 eggs in their wet environment, and maybe gaurds them aggressively.",
                Diet = "fish, amphibians, amphibian eggs (including their own).",
                Size = "19.5 cm",
                ConservationStatus = "Least Concern",
                Predators = "Garter Snakes, water shrew.",
                InvasiveStatus = false
            },
            new HerpList
             {
                 HerpListId = 5,
                 ScientificName = "Dicamptodon tenebrosus",
                 CommonName = "Coastal Giant Salamander",
                 Classification = "Amphibian",
                 PhotoPath= "../wwwroot/uploads/coastalGiantSalamander.jpg",
                 Description = "light brown or brass-colored skin with dark marbled or reticulated blotched pattern. They are one of the few salamanders capable of vocalizing.",
                 Habitat = "Small to midsize streams and moist riverside forests with Gravel to small-boulder covered stream beds. They can also be found under forest debris during rainy periods. They can be found in elevations ranging from sea level to 1830 m.",
                 Diet = "Larvae will consume insects, insect larvae, amphipods, ostracods, termatoes, molusks, crayfish, eggs. Adults will eat small mammals, snakes, amphibians, fish, other marine invertebrates.",
                 Size = "34 cm",
                 ConservationStatus = "Least Concern",
                 Predators = "Weasels, river otters, water shrews, garter snakes, salmonids, conspecifics.",
                 InvasiveStatus = false
             },
             new HerpList
             {
                 HerpListId = 6,
                 ScientificName = "Rhyacotriton kezeri",
                 CommonName = "Columbia Torrent Salamander",
                 Classification = "Amphibian",
                 Description= "There isn't much known about this species.",
                 Habitat = "Temperate forests, rivers, and freshwater springs. Clear, cold, mountain springs.",
                 Size = "10 cm",
                 ConservationStatus = "Near Threatened",
                 InvasiveStatus = false
             },
             new HerpList
             {
                 HerpListId = 7,
                 ScientificName = "Rhyacotriton variegatus",
                 CommonName = "Southern Torrent Salamander",
                 Classification = "Salamander",
                 PhotoPath = "../wwwroot/uploads/southernTorrentSalamander.jpg",
                 Description = "",
                 Habitat = "",
                 Size= "4-6.2 cm",
                 Diet = "",
                 ConservationStatus = "Least Concern",
                 Predators = "",
                 InvasiveStatus = false
             }
            );
        }
    }
}