using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SiteCountries.Models;

namespace SiteCountries.Controllers.API
{
    public class CountriesController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(string country)
        {
          return Request.CreateResponse(HttpStatusCode.OK, $"Country {country} Add");
        }
    }
}
