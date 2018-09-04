using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gcCarFinalProject.Domain.Models
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
