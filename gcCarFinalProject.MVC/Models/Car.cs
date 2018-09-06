using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gcCarFinalProject.MVC.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string CarMake { get; set; }

        public string CarModel { get; set; }

        public int CarYear { get; set; }

        public string CarColor { get; set; }
    }
}