using System.ComponentModel.DataAnnotations;

namespace SmosOS.Models
{
    public class Ingredient
    {
        public string IngredientID { get; set; }
        [Required, MaxLength(40)]
        public string Naam { get; set; }
        [Required]
        public Decimal prijs { get; set; }
        [Required]
        public int Hoeveelheid { get; set; }
        [Required, MaxLength(10)]
        public string Eenheid { get; set; }

        //constraints
        public ICollection<IngredientLeverancier> IngredientLeveranciers { get; set; }
        public ICollection<BroodjeIngredient> BroodjeIngredienten { get; set; }
    }
}
