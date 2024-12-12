using System.ComponentModel.DataAnnotations;

namespace SmosOS.Models
{
    public class Leverancier
    {
        public string LeverancierID { get; set; }
        [Required, MaxLength(50)]
        public string Naam { get; set; }
        [Required]
        public string AdresID { get; set; }
        public Adres Adres { get; set; }
        [MaxLength(50)]
        public string VoornaamContactpersoon { get; set; }
        [MaxLength(50)]
        public string FamilienaamContactpersoon { get; set; }
        [MaxLength(15)]
        public string Telefoonnummer { get; set; }
        [Required, MaxLength(50)]
        public string Mailadres { get; set; }

        //constraints
        public ICollection<IngredientLeverancier> IngredientLeveranciers { get; set; }

    }
}
