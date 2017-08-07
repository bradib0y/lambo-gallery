using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LamboGallery.Models;

namespace LamboGallery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Monday) { return new RedirectResult("/"); }
            Lambo LamboModel = new Lambo()
            {
                Type = "Aventador",
                Variety = "LP-700-4",
                Description = "<p>Launched on 28 February 2011 at the Geneva Motor Show, five months after its initial unveiling in Sant'Agata Bolognese, the vehicle, internally codenamed LB834, was designed to replace the then-decade-old Murciélago as <strong>the new flagship model.</strong></p>",
                Properties = new LamboProperty[]
            {
        new LamboProperty(){PropertyName = "Displacement", PropertyValue = "6,498 cc (396.5 cu in)"},
        new LamboProperty(){PropertyName = "Max. power", PropertyValue = "700 PS (510 kW; 690 bhp) @ 8,250 rpm"},
        new LamboProperty(){PropertyName = "Power to weight", PropertyValue = "432 PS (318 kW; 426 bhp) per tonne"},
        new LamboProperty(){PropertyName = "Max. torque", PropertyValue = "689 N·m (508 lb·ft) @ 5,500 rpm"},
        new LamboProperty(){PropertyName = "CO2 emissions", PropertyValue = "398 g/km"},
        new LamboProperty(){PropertyName = "Combined fuel consumption", PropertyValue = "17.2 L/100 km (16.4 mpg‑imp; 13.7 mpg‑US)"}
                /*

        Displacement	6,498 cc (396.5 cu in)
        Max. power	700 PS (510 kW; 690 bhp) @ 8,250 rpm
        Power to weight	432 PS (318 kW; 426 bhp) per tonne
        Max. torque	689 N·m (508 lb·ft) @ 5,500 rpm
        CO2 emissions	398 g/km
        Combined fuel consumption	17.2 L/100 km (16.4 mpg‑imp; 13.7 mpg‑US)
                 */
        }
            };
        

            

            return View(LamboModel); // storngly typed view
        }

    }
}