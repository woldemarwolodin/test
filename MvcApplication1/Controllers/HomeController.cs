﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            string test = "Na, da hab ich mich doch nicht vertan";
            string nullString = null;
            long langeId = 5983475934;
            string test2 = "NEIN, TUE ES NICHT!";
            string test3 = "Git kann halt auch nicht alles";
            string test4 = "Nur für den Featurebranch";
            string test5 = "Alter!!!";
            return View();
        }

    }
}
