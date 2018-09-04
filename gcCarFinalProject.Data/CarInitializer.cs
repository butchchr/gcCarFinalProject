using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using gcCarFinalProject.Domain.Models;

namespace gcCarFinalProject.Data
{
    class CarInitializer : DropCreateDatabaseAlways<CarContext>
    {
        protected override void Seed(CarContext context)
        {
            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Camry",
                CarColor = "Tan",
                CarYear = 2004
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Supra",
                CarColor = "Red",
                CarYear = 1999
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "4 Runner",
                CarColor = "Black",
                CarYear = 2011
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "FJ Crusier",
                CarColor = "Blue",
                CarYear = 2013
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Highlander",
                CarColor = "Silver",
                CarYear = 2012
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Tundra",
                CarColor = "Gold",
                CarYear = 2009
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Tacoma",
                CarColor = "Black",
                CarYear = 2018
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Rav4",
                CarColor = "Pink",
                CarYear = 2010
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Land Cruiser",
                CarColor = "Pearl White",
                CarYear = 2019
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Sienna",
                CarColor = "Tan",
                CarYear = 2011
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Prius",
                CarColor = "Green",
                CarYear = 2009
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Corolla",
                CarColor = "White",
                CarYear = 1997
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "MR2",
                CarColor = "Red",
                CarYear = 1993
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Avalon",
                CarColor = "Gold",
                CarYear = 2013
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Celica",
                CarColor = "Yellow",
                CarYear = 2004
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Tercel",
                CarColor = "Red",
                CarYear = 1995
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Matrix",
                CarColor = "Blue",
                CarYear = 2008
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Cressida",
                CarColor = "Tan",
                CarYear = 1988
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Echo",
                CarColor = "Silver",
                CarYear = 2002
            });

            context.Cars.Add(new Car()
            {
                CarMake = "Toyota",
                CarModel = "Yaris",
                CarColor = "White",
                CarYear = 2016
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
