using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using gcCarFinalProject.Data;
using gcCarFinalProject.Domain.Models;
using gcCarFinalProject.Models;

namespace gcCarFinalProject.Controllers
{
    public class CarsController : ApiController
    {
        private CarContext db = new CarContext();

        [HttpGet]
        public IEnumerable<Car> Get(CarQueryModel model)
        {
            IQueryable<Car> cars = db.Cars;
            if (! string.IsNullOrWhiteSpace(model.Make))
            {
                cars = cars.Where(c => string.Equals(c.CarMake, model.Make, StringComparison.CurrentCultureIgnoreCase));
            }
            
            if (!string.IsNullOrWhiteSpace(model.Model))
            {
                cars = cars.Where(c => string.Equals(c.CarModel, model.Model, StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(model.Color))
            {
                cars = cars.Where(c => string.Equals(c.CarColor, model.Color, StringComparison.CurrentCultureIgnoreCase));
            }

            if (model.Year.HasValue)
            {
                cars = cars.Where(c => c.CarYear == model.Year.Value);
            }

            return cars;
        }

        [HttpPut]
        public IHttpActionResult Put(Car model)
        {
            this.db.Cars.Add(model);
            this.db.SaveChanges();

            return this.StatusCode(HttpStatusCode.Created);
        }

        [HttpPatch]
        public IHttpActionResult Patch(Car model)
        {
            var car = this.db.Cars.SingleOrDefault(c => c.Id == model.Id);

            if (car != null)
            {
                // TODO: update the fields on the matched entity
                this.db.SaveChanges();

                return this.StatusCode(HttpStatusCode.NoContent);
            }

            return this.NotFound();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var car = this.db.Cars.SingleOrDefault(c => c.Id == id);

            if (car != null)
            {
                this.db.Cars.Remove(car);
                this.db.SaveChanges();

                return this.StatusCode(HttpStatusCode.NoContent);
            }

            return this.NotFound();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}