using System.ComponentModel.DataAnnotations;

namespace SmosOS.Models
{
    public class OrderBroodje
    {
        public string OrderBroodjeID { get; set; }
        [Required]
        public string OrderID { get; set; }
        public Order Order { get; set; }
        [Required]
        public string BroodjeID { get; set; }
        public Broodje Broodje { get; set; }
    }
}
