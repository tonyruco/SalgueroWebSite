using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalgueroRich.Controllers
{
    public class AttorneyProfileController : Controller
    {
        // GET: AttorneyProfile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OmarSalguero()
        {
            return View();
        }

        public ActionResult DavidRichmond()
        {
            return View();
        }
    }
}