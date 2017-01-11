using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiteCountries.Models;
using SiteCountries.Repository.Abstract;

namespace SiteCountries.Repository.Implementation
{
    public class CountriesRepository : ICountriesRepository
    {
        private readonly SiteCountriesEntities _context;
        private readonly Countries _countries;

        public CountriesRepository()
        {
            _context = new SiteCountriesEntities();
            _countries = new Countries();
        }
        public void AddCountry(string country)
        {
            _countries.CountryName = country;
            _context.Countries.AddObject(_countries);
            _context.SaveChanges();
        }
    }
}