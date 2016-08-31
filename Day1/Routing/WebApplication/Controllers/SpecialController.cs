using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class SpecialController : Controller
    {
        // GET: Special
        public JsonResult OutputToJson()
        {

            string[] model = new string[]
        {
            "Action",
            "Json"
        };
            return Json(model, JsonRequestBehavior.AllowGet);

        }
    }
}