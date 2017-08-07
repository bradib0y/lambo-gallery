using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LamboGallery.Models
{
    public class Lambo
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Variety { get; set; }
        public string Description { get; set; }
        public LamboProperty[] Properties { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText {
            get { return Type + " " + Variety; }
        }

        public string CoverImageFileName {
            get { return "/Images/" + ((Type.Replace(" ", "-") + "-" + Variety.Replace(" ", "-") + ".jpg").ToLower()); }
        }
    }
}