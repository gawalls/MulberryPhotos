using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
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
            model.EmailSent = false;
            model = WebSiteViewModelService.GetEnquiryViewModel(model);
            
            if (ModelState.IsValid)
            {
                MailMessage message = new MailMessage();
                message.To.Add(model.ToEmailAddress);
                message.Subject = "Mulberry photos enquiry";
                message.Body = model.HtmlMessageBody;
                message.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Send(message);                    
                    model.EmailSent = true;
                }
            }
            return View(model);
        }
    }
}