using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gcCarFinalProject.Models
{
    public class CarQueryModel
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int? Year { get; set; }

        public string Color { get; set; }
    }
}