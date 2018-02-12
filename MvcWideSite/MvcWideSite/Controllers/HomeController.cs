using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MulberryPhotos.DataAccess.Enums;
using MvcWideSite.Models;
using MvcWideSite.ViewModels;

namespace MvcWideSite.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(string routeName = null)
        {
            if (routeName == null)
                routeName = Constants.RoutingNames.Home;

            WebPageViewModel model = WebSiteViewModelService.GetViewModel(routeName);

            if (model == null)
            {
                return HttpNotFound($"{routeName} not found");
            }
            
            return View(model);            
        }

        public ActionResult Contact()
        {
            EnquiryViewModel model = WebSiteViewModelService.GetEnquiryViewModel();

            if (model == null)
            {
                return HttpNotFound($"{Constants.RoutingNames.Contact} not found");
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Contact(EnquiryViewModel model)
        {
            model = WebSiteViewModelService.GetEnquiryViewModel(model);
            
            if (ModelState.IsValid)
            {
                throw new NotImplementedException("Save method will go here - once the database and email of the hosting server is joined up.");
            }
            return View(model);
        }             
    }
}