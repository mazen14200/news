using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace news.Controllers
{
    public class adminController : Controller
    {
        // GET: Admin
        public ActionResult Dashbord()
        {
            return View();
        }
    }
}