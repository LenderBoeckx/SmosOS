using System.ComponentModel.DataAnnotations;

namespace SmosOS.Models
{
    public class Order
    {
        public string OrderID { get; set; }
        [Required]
        public string KlantID { get; set; }
        public Klant Klant { get; set; }
        [Required]
        public Decimal Prijs { get; set; }
        [Required]
        public DateOnly Datum {  get; set; }

        //constraints
        public ICollection<OrderBroodje> OrderBroodjes { get; set; }
    }
}
