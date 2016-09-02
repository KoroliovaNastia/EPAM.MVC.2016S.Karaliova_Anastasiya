using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace Routing
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
