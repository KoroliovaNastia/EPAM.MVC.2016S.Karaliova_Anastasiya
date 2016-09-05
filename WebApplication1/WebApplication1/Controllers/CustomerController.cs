using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
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
    }
}