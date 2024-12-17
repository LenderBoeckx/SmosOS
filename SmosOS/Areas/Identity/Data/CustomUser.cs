using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SmosOS.Areas.Identity.Data
{
    public class CustomUser : IdentityUser
    {
        [PersonalData, MaxLength(50, ErrorMessage = "De ingevulde naam is te lang. De maximale lengte is 50"), Required]
        public string Voornaam { get; set; }
        [PersonalData, MaxLength(50, ErrorMessage = "De ingevulde naam is te lang. De maximale lengte is 50"), Required]
        public string Familienaam { get; set; }
    }
}
