using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using MulberryPhotos.DataAccess.Repositories;

namespace MvcWideSite.Models
{
    public static class Constants
    {
        public static class Locations
        {
            public static string WebDataXmlFile
            {
                get
                {
                    //return HttpContext.Current.Server.MapPath(@"~/App_Data/WebsiteContent.xml");
                    return HostingEnvironment.MapPath(@"~/App_Data/WebsiteContent.xml");
                }
            }
        }

        public static class RoutingNames
        {
            public const string Home = "home";
            public const string Contact = "contact";
        }

        public const string ToLookupValue = "ToEmailAddress";
    }    
}