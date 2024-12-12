using System.ComponentModel.DataAnnotations;

namespace SmosOS.Models
{
    public class Adres
    {
        public string AdresID { get; set; }
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
    }
}
