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
        public string[] Properties { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText {
            get { return Type + " " + Variety; }
        }

        public string CoverImageFileName {
            get { return Type.Replace(" ", "-").ToLower() + "-" + Variety.Replace(" ", "-") + ".jpg"; }
        }
    }
}