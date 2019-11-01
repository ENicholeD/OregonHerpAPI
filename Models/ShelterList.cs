using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
    public class ShelterList
    {
        public int ShelterListId {get; set;}
        [Required]
        [StringLength(20)]
        public string Name {get; set;}
        [Required]
        public string PhotoPath {get; set;}
        [Required]
        [StringLength(20)]
        public string AnimalType {get; set;}
        [Required]
        [StringLength(30)]
        public string Breed {get; set;}
        [Required]
        [StringLength(30)]
        public string Gender {get; set;}
        [Required]
        public int Age {get; set;}
        [Required]
        [StringLength(15)]
        public string KennelNumber {get; set;}
        [Required]
        [StringLength(500)]
        public string Description {get; set;}
    }
}