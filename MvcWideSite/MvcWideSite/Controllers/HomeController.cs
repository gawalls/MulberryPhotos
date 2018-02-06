using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MulberryPhotos.DataAccess.Enums;
using MvcWideSite.ViewModels;

namespace MvcWideSite.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(string routeName = null)
        {
            if (routeName == null)
                routeName = "home";

            WebPageViewModel model = WebSiteViewModelService.GetViewModel(routeName);

            if (model == null)
            {
                return HttpNotFound($"{routeName} not found");
            }

            return View(model);            
        }        
    }
}