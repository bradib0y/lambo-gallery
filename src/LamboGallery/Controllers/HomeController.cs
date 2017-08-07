using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LamboGallery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Monday) { return new RedirectResult("/"); }

            ViewBag.Type = "Aventador";
            ViewBag.Variety = "LP-700-4";
            ViewBag.Description = "<p>Launched on 28 February 2011 at the Geneva Motor Show, five months after its initial unveiling in Sant'Agata Bolognese, the vehicle, internally codenamed LB834, was designed to replace the then-decade-old Murciélago as <strong>the new flagship model.</strong></p>";
            ViewBag.Properties = new string[]
            {
        "Displacement: 6,498 cc (396.5 cu in)",
        "Max. power: 700 PS (510 kW; 690 bhp) @ 8,250 rpm",
        "Power to weight: 432 PS (318 kW; 426 bhp) per tonne",
        "Max. torque: 689 N·m (508 lb·ft) @ 5,500 rpm",
        "CO2 emissions: 398 g/km",
        "Combined fuel consumption: 17.2 L/100 km (16.4 mpg‑imp; 13.7 mpg‑US)"
                /*

        Displacement	6,498 cc (396.5 cu in)
        Max. power	700 PS (510 kW; 690 bhp) @ 8,250 rpm
        Power to weight	432 PS (318 kW; 426 bhp) per tonne
        Max. torque	689 N·m (508 lb·ft) @ 5,500 rpm
        CO2 emissions	398 g/km
        Combined fuel consumption	17.2 L/100 km (16.4 mpg‑imp; 13.7 mpg‑US)
                 */
        };

            return View();
        }

    }
}