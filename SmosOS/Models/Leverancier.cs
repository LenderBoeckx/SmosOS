using System.ComponentModel.DataAnnotations;

namespace SmosOS.Models
{
    public class Leverancier
    {
        public string LeverancierID { get; set; }
        [Required, MaxLength(50)]
        public string Naam { get; set; }
        [MaxLength(50)]
        public string VoornaamContactpersoon { get; set; }
        [MaxLength(50)]
        public string FamilienaamContactpersoon { get; set; }
        [MaxLength(15)]
        public string Telefoonnummer { get; set; }
        [Required, MaxLength(50)]
        public string Mailadres { get; set; }
        [Required, MaxLength(70)]
        public string Straatnaam { get; set; }
        [Required, MaxLength(10)]
        public string Huisnummer { get; set; }
        [Required, MaxLength(50)]
        public string Toevoeging { get; set; }
        [Required, MaxLength(50)]
        public string Stad { get; set; }
        [Required, MaxLength(10)]
        public string Postcode { get; set; }
        [Required, MaxLength(50)]
        public string Land { get; set; }

        //constraints
        public ICollection<IngredientLeverancier> IngredientLeveranciers { get; set; }

    }
}
