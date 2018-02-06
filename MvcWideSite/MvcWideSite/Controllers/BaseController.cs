using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MulberryPhotos.DataAccess.Interfaces;
using MulberryPhotos.DataAccess.Services;
using MvcWideSite.Services;

namespace MvcWideSite.Controllers
{
    public class BaseController : Controller
    {
        private IWebContentService _webContentService;
        private IWebContentService WebContentService
        {
            get
            {
                if (_webContentService == null)
                {
                    _webContentService = ServiceBuilder.GetWebContentService();
                }

                return _webContentService;
            }
        }

        private WebSiteViewModelService _webSiteViewModelService;

        protected WebSiteViewModelService WebSiteViewModelService
        {
            get
            {
                if (_webSiteViewModelService == null)
                {
                    _webSiteViewModelService = ServiceBuilder.GetViewModelService(WebContentService);
                }

                return _webSiteViewModelService;
            }
        }
    }
}