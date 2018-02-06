using MulberryPhotos.DataAccess.Interfaces;
using MulberryPhotos.DataAccess.Services;
using MvcWideSite.Models;

namespace MvcWideSite.Services
{
    public static class ServiceBuilder
    {
        public static IWebContentService GetWebContentService()
        {
            string filename = Constants.Locations.WebDataXmlFile;

            return new XmlWebContentService(filename);
        }

        public static WebSiteViewModelService GetViewModelService(IWebContentService webContentService)
        {
            return new WebSiteViewModelService(webContentService);
        }
    }
}