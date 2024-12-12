using System.ComponentModel.DataAnnotations;

namespace SmosOS.Models
{
    public class BroodjeIngredient
    {
        public string BroodjeIngredientID { get; set; }
        [Required]
        public string BroodjeID { get; set; }
        public Broodje Broodje { get; set; }
        [Required]
        public string IngredientID { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
