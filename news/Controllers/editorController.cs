using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace news.Controllers
{
    public class editorController : Controller
    {
        // GET: Editor
        public ActionResult Factory()
        {
            return View();
        }
    }
}