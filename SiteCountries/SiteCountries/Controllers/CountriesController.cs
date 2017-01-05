using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiteCountries.Models;
using SiteCountries.Repository.Abstract;

namespace SiteCountries.Controllers
{
    public class CountriesController : Controller
    {

        private readonly ICountriesRepository _countriesRep;

        public CountriesController(ICountriesRepository countriesRep)
        {
            _countriesRep = countriesRep;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}