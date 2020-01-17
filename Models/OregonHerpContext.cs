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
                 Breeding = "Tiger salamaders are loyal to where they were born and will travel long distances to return. They have only a 50% chance of breeding more than once in their lifetime and only breed in the later winter and early spring months. This is aproximately when the ground is warmer and the water has thawed. After nudging a willing female, the male will deposite a spermatophore on the lake bottom. After about 48 hours after insemination, the female will lay her eggs in the breeding pool, attaching them to secure places to ensure their safety. It takes Roughly 12-50 days for all of the eggs to hatch, and 3 months to fully mature into adults. Their larvae are entirely aquatic with external gills and a prominent caudal fin, similar to Axolotls. As they grow, they develope limbs shortly after hatching. In certain cases, such as with seasonal pools, they may mature faster, becoming small morph adults. In other cases where the weather is warmer and ancestral pools, they may not metamorphose until they are adult size. They also have been known to never metamorphose and stay in their larva stage their entire lives and reach sexual maturity while in their larva form.",
                 Diet = "Insects, earthworms, grubs, small snails, slugs, minnows, other amphibians (in rare cases, other tiger salamanders), crustacians (while in their larva form).",
                 Lifespan = "12-15 years",
                 Size = "15-35 cm",
                 ConservationStatus = "Least Concern",
                 Diseases = "Although immune, tiger salamaders transmit amphibian chytrid fungus which causes Chytridiomycosis which affects amphibians worldwide. They also carry ranaviruses which infects reptiles, amphibians, and fish, and has been linked to high mortality in tiger salamander larvae when there's reoccuring ranavirus infections.",
                 Predators = "Racoons, Coatis, river turtles.",
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
                 Breeding = "Northwestern Salamanders breed in low-elevation sites during June to late August after migrating to breeding sites between January and April. They become sexually mature at 1-2 years of age. Their breeding occures in permanent and semi-permanent lakes, ponds, wetlands, and slow flowing rivers and streams, even if ice is still present. Males will often arrive before females, and the breading season lasts aproximately 1-7 weeks, which is dependant on the temperature increase rate of the water.",
                 Diet = "Small invertebrates, aquatic invertebrates, tadpoles, snails, worms, fairy shrimp.",
                 Lifespan = "5 years",
                 Size = "14-22 cm",
                 ConservationStatus = "Least Concern",
                 Diseases = "",
                 Predators = "",
                 InvasiveStatus = false
             },
             new HerpList
             {
                 HerpListId = 3,
                 ScientificName = "Dicamptodon copei",
                 CommonName = "Cope's Giant Salamander",
                 Classification = "Amphibian",
                 Description = "",
                 Habitat = "",
                 Breeding = "",
                 Diet = "",
                 Lifespan = "",
                 Size = "",
                 ConservationStatus = "",
                 Diseases = "",
                 Predators = "",
                 InvasiveStatus = false
             },
             new HerpList
             {
                 HerpListId = 4,
                 ScientificName = "Rhyacotriton kezeri",
                 CommonName = "Colombia Torrent Salamander",
                 Classification = "Amphibian",
                 Description = "",
                 Habitat = "",
                 Breeding = "",
                 Diet = "",
                 Lifespan = "",
                 Size = "",
                 ConservationStatus = "",
                 Diseases = "",
                 Predators = "",
                 InvasiveStatus = false
             },
             new HerpList
             {
                 HerpListId = 5,
                 ScientificName = "Rhyacotriton variegatus",
                 CommonName = "Southern Torrent Salamander",
                 Classification = "Amphibian",
                 Description = "",
                 Habitat = "",
                 Breeding = "",
                 Diet = "",
                 Lifespan = "",
                 Size = "",
                 ConservationStatus = "",
                 Diseases = "",
                 Predators = "",
                 InvasiveStatus = false
             }
             
            );
        }
    }
}