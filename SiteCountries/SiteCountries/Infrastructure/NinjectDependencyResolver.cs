using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Ninject.Parameters;
using Ninject.Syntax;
using System.Configuration;
using SiteCountries.Repository.Abstract;
using SiteCountries.Repository.Implementation;

namespace SiteCountries.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;
        public NinjectDependencyResolver()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            _kernel.Bind<ICountriesRepository>().To<CountriesRepository>();
        }
    }
}