using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Infrastructure;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View("Result", new Result
            {

                ControllerName = "ControllerName",
                ActionName = "ActionName"

            });
        }

        public ActionResult List()
        {
            return View("Result", new Result
            {

                ControllerName = "ControllerName",
                ActionName = "ActionName"

            });
        }

        [Local]
        [ActionName("Index")]
        public ActionResult LocalIndex()
        {
            return View("Result", new Result
            {

                ControllerName = "ControllerName",
                ActionName = "ActionName"

            });
        }
    }
}