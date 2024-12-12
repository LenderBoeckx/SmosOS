using System.ComponentModel.DataAnnotations;

namespace SmosOS.Models
{
    public class IngredientLeverancier
    {
        public string IngredientLeverancierID {  get; set; }
        [Required]
        public string IngredientID { get; set; }
        public Ingredient Ingredient { get; set; }
        [Required]
        public string LeverancierID { get; set; }
        public Leverancier Leverancier { get; set; }
    }
}
