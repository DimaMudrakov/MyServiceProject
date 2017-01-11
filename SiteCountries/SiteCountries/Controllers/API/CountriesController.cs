using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SiteCountries.Repository.Abstract;
using SiteCountries.Utils;

namespace SiteCountries.Controllers.API
{
    public class CountriesController : ApiController
    {
        private readonly ICountriesRepository _repository;

        public CountriesController(ICountriesRepository repository)
        {
            _repository = repository;
        }

        public HttpResponseMessage Post([FromBody] string country)
        {
            try
            {
                _repository.AddCountry(country);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ResponseHandler.Message);
            }
            return Request.CreateResponse(HttpStatusCode.OK, $"Country {country} Add");
        }//The country is not added
    }
}
