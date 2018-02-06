using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWideSite.Controllers
{
    public class AboutController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}