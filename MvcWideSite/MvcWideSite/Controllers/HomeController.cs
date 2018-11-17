using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
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

            string recaptchaResponse = Request["g-recaptcha-response"];

            model.IsHuman = ValidateRecaptcha(recaptchaResponse);

            if (ModelState.IsValid && model.IsHuman)
            {
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
            }

            return View(model);
        }

        private bool ValidateRecaptcha(string recaptchaResponse)
        {
            try
            {
                string sectret = ConfigurationManager.AppSettings["captchaKey"]; 
                string url = $"https://www.google.com/recaptcha/api/siteverify?secret={sectret}&response={recaptchaResponse}&remoteip={Request.UserHostAddress}";
                WebRequest webRequest = WebRequest.Create(url);
                //webRequest.Method = "POST";

                using (WebResponse response = webRequest.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string jsonResonse = reader.ReadToEnd();

                        JavaScriptSerializer js = new JavaScriptSerializer();
                        RecaptchaResult result = js.Deserialize<RecaptchaResult>(jsonResonse);
                        return Convert.ToBoolean(result.success);
                    }
                }
                
            }
            catch (Exception exc)
            {
                return false;
            }

            return false;
        }
    }
}