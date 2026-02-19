using Flight.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flight.Controllers
{
    public class FlightsController : Controller
    {
        private FlightContext context { get; set; }

        public FlightsController(FlightContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new FlightModel());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Disable = "";
            var flight = context.FlightModel.Find(id);
            return View(flight);
        }

        [HttpPost]
        public IActionResult Edit(FlightModel flightModel)
        {
            if (ModelState.IsValid)
            {
                if (flightModel.FlightModelId == 0)
                    context.FlightModel.Add(flightModel);
                else
                    context.FlightModel.Update(flightModel);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (flightModel.FlightModelId == 0) ? "Add" : "Edit";
                return View(flightModel);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var flight = context.FlightModel.Find(id);
            return View(flight);
        }

        [HttpPost]
        public IActionResult Delete(FlightModel flightModel)
        {
            context.FlightModel.Remove(flightModel);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
