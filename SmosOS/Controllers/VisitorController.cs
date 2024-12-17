using Microsoft.AspNetCore.Mvc;
using SmosOS.Data;
using SmosOS.ViewModels;

namespace SmosOS.Controllers
{
    public class VisitorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VisitorController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Catalogus()
        {
            BroodjesOverviewViewModel vm = new BroodjesOverviewViewModel()
            {
                Broodjes = _context.Broodjes.ToList()
            };
            return View(vm);
        }
    }
}
