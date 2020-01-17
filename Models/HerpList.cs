using System.ComponentModel.DataAnnotations;

namespace OregonHerp.Models
{
    public class HerpList
    {
        [Required]
        public int HerpListId {get; set;}
        [Required]
        public string ScientificName {get; set;}
        public string CommonName {get; set;}
        public string Classification {get; set;}
        public string PhotoPath {get; set;}
        [Required]
        public string Description {get; set;}
        [Required]
        public string Habitat {get; set;}
        public string Breeding {get; set;}
        public string Diet {get; set;}
        public string Lifespan {get; set;}
        public string Size {get; set;}
        public string ConservationStatus {get; set;}
        public string Diseases {get; set;}
        public string Predators {get; set;}
        [Required]
        public bool InvasiveStatus {get; set;}

    }
}