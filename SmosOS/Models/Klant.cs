using System.ComponentModel.DataAnnotations;

namespace SmosOS.Models
{
    public class Klant
    {
        public string KlantID { get; set; }
        [Required, MaxLength(50)]
        public string Voornaam { get; set; }
        [Required, MaxLength(50)]
        public string Familienaam { get; set; }
        [Required]
        public string AdresID { get; set; }
        public Adres Adres { get; set; }
        [Required, MaxLength(15)]
        public string Telefoonnummer { get; set; }
        [Required, MaxLength(50)]
        public string mailadres { get; set; }

    }
}
