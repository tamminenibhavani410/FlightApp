using Flight.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flight.Controllers
{
    public class HomeController : Controller
    {
        private FlightContext context { get; set; }

        public HomeController(FlightContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var flights = context.FlightModel.OrderBy(m => m.FlightNumber).ToList();
            return View(flights);
        }
    }
}
