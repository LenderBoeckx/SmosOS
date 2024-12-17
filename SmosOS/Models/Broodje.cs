using System.ComponentModel.DataAnnotations;

namespace SmosOS.Models
{
    public class Broodje
    {
        public string BroodjeID { get; set; }
        [Required, MaxLength(40)]
        public string Naam { get; set; }
        [Required, MaxLength(300)]
        public string Omschrijving { get; set; }
        [Required]
        public Decimal Prijs { get; set; }
        [Required]
        public bool Voorraad { get; set; }
        public string Afbeelding { get; set; }

        //constraints
        public ICollection<OrderBroodje> OrderBroodjes { get; set; }
        public ICollection<BroodjeIngredient> BroodjeIngredienten { get; set; }
    }
}
