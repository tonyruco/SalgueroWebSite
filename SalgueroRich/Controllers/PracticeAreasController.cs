using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalgueroRich.Controllers
{
    public class PracticeAreasController : Controller
    {
        // GET: PracticeAreas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ImmigrationLaw()
        {
            return View();
        }

        public ActionResult CriminalDefense()
        {
            return View();
        }

        public ActionResult FamilyLaw()
        {
            return View();
        }

        public ActionResult FamilyPetition()
        {
            return View();
        }

        public ActionResult BusinessImmigration()
        {
            return View();
        }

        public ActionResult DeportationRemoval()
        {
            return View();
        }
    }
}