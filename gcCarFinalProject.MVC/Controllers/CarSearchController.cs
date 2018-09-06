using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Web;
using gcCarFinalProject.MVC.Models;
using System.Net;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using System.Text;

namespace gcCarFinalProject.MVC.Controllers
{
    public class CarSearchController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CarSearchModel model)
        {
            if (this.ModelState.IsValid)
            {
                var theSetting = ConfigurationManager.AppSettings["ApiUriBase"];

                var theEndpoint = theSetting += "Cars";

                UriBuilder theEndpointUriBuilder = new UriBuilder(theEndpoint);
                IDictionary<string, string> query = new Dictionary<string, string>();

                if (!string.IsNullOrWhiteSpace(model.CarColor))
                {
                    query["Color"] = model.CarColor;
                }

                if (!string.IsNullOrWhiteSpace(model.CarModel))
                {
                    query["Model"] = model.CarModel;
                }

                if (!string.IsNullOrWhiteSpace(model.CarMake))
                {
                    query["Make"] = model.CarMake;
                }

                if (model.CarYear.HasValue)
                {
                    query["Year"] = model.CarYear.Value.ToString();
                }
                
                foreach (var kvp in query)
                {
                    theEndpointUriBuilder.Query = kvp.Key + "=" + Uri.EscapeDataString(kvp.Value);
                }

                var request = (HttpWebRequest)WebRequest.Create(theEndpointUriBuilder.Uri.ToString());
                request.Method = "GET";
                request.Accept = "application/json";

                HttpWebResponse response = null;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    try
                    {
                        response = (HttpWebResponse)request.GetResponse();

                        var responseStream = response.GetResponseStream();
                        string content;
                        using (var reader = new StreamReader(responseStream))
                        {
                            content = reader.ReadToEnd();
                        }

                        var cars = JsonConvert.DeserializeObject<IEnumerable<Car>>(content);

                        return View("Results", cars);
                    }
                    finally
                    {
                        response?.Dispose();
                    }
                }
                else
                {
                    // TODO error reporting
                    this.ModelState.AddModelError(string.Empty, "Http request failed " + response.StatusDescription);
                }
            }

            return View(model);
        }
    }
}