using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SiteCountries.Repository.Implementation;
using SiteCountries.Utils;

namespace SiteCountries.Controllers.API
{
    public class CountriesController : ApiController
    {
        private readonly CountriesRepository _repository;

        public CountriesController()
        {
                _repository = new CountriesRepository();
        }

        public HttpResponseMessage Post([FromBody] string country)
        {
            ResponseHandler response = new ResponseHandler()
            {
                Message = $"Country {country} Add",
                ExceptionMessage = $"The country {country} is not added"
            };
            try
            {
                _repository.AddCountry(country);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, response);
            }
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
    }
}
