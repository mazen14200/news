using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace news.Controllers
{
    public class viewerController : Controller
    {
        // GET: Viewer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Wall()
        {
            return View();
        }
    }
}