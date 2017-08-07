using LamboGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LamboGallery.Data
{
    public class LamboRepository

    {
        /* Lambo Repository */
        private static Lambo[] _lambos = new Lambo[] 
        {
            /**/
                        new Lambo()
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
                        }
                    },
            /**/
            new Lambo(){
                        Type = "Huracan",
                        Variety = "LP-640-4 Performante",
                        Description = "<p>The Lamborghini Huracán is a sports car built by Lamborghini, replacing Lamborghini's sales leader and most produced car, the Gallardo. The Huracán made its auto show debut at the March 2014 Geneva Auto Show, and was released in the second quarter of 2014. The name of the Huracan LP 610-4 comes from the fact that this car has 610 horsepower and 4 wheel drive. The Huracán was named <strong>The Supercar of the Year 2014</strong> by car magazine Top Gear.</p>",
                        Properties = new LamboProperty[]
                        {
                    new LamboProperty(){PropertyName = "Power@rpm", PropertyValue = "640 PS (471 kW; 631 hp) @ 8,000 rpm"},
                    new LamboProperty(){PropertyName = "Torque@rpm", PropertyValue = "600 N·m (443 lb·ft) @ 6,500 rpm"},
                    new LamboProperty(){PropertyName = "Braking 100km/h-0", PropertyValue = "31m"},
                    new LamboProperty(){PropertyName = "0 to 100 km/h (62 mph) (sec)", PropertyValue = "2.9"},
                    new LamboProperty(){PropertyName = "CO2 emissions", PropertyValue = "314g/km"},
                    new LamboProperty(){PropertyName = "Top speed", PropertyValue = ">325 km/h (202 mph)"}
                        }
                    },
            /**/
                        new Lambo(){
                        Type = "Centenario",
                        Variety = "One Off",
                        Description = "<p>The new Lamborghini Centenario represents a new, extremely precious piece in Lamborghini's one-off strategy. It is a perfect example of the innovative design and the engineering skills of the bull-branded manufacturer. The best <strong>tribute to the 100th anniversary of the birth of Mr. Ferruccio Lamborghini</strong>, a man who managed to create a world-class brand, and who always believed that nothing is impossible, thus producing legendary and extraordinary vehicles that made history for super sports cars.</p>",
                        Properties = new LamboProperty[]
                        {
                    new LamboProperty(){PropertyName = "Displacement", PropertyValue = "6.498 cm³ (396.5 cu in)"},
                    new LamboProperty(){PropertyName = "Max. Power", PropertyValue = "770 CV (566 kW) @ 8.500 rpm"},
                    new LamboProperty(){PropertyName = "Max. Torque", PropertyValue = "690 Nm (507 lb.-ft.) @ 5.500 rpm"},
                    new LamboProperty(){PropertyName = "Max. Speed", PropertyValue = "> 350 km/h (> 217 mph)"}
                        }
                    },
            /**/
        };

        public static Lambo[] Lambos { get => _lambos; set => _lambos = value; }

        /********************/
        public Lambo GetLambo() { return new Lambo()
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
        }
    }
}