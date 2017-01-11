using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace SiteCountries.Utils
{
    public static class ResponseHandler : HttpResponseMessage
    {
        public static string Message { get; set; }
        public static string ExceptionMessage { get; set; }
    }
}