using System;
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
            string nullString = null;
            long langeId = 5983475934;
            string test = "NEIN, TUE ES NICHT!";
            return View();
        }

    }
}
