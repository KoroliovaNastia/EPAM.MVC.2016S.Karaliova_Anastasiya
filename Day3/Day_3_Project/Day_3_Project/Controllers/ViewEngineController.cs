using Day_3_Project.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_3_Project.Controllers
{
    public class ViewEngineController : Controller
    {
        // GET: ViewEngine
        public ActionResult Index()
        {

            return View(new CustomDataView());
        }

        public ActionResult Action()
        {
            string[] str = new string[] { "one", "two", "three" };
            return View(str);
        } 
    }
}