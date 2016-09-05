using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebProject.Controllers
{
    public class CustomerController : Controller
    {
        [HttpPost]
        [ActionName("Add-User")]
        public async Task<ActionResult> Add()
        {

            return RedirectToAction("User-List");
        }

        [HttpGet]
        [ActionName("User-List")]
        public ActionResult List()
        {
            return View();
        }

        [HttpPost]
        [ActionName("User-List")]
        public JsonResult UserList()
        {
            return Json("Users", JsonRequestBehavior.AllowGet);
        }
       
    }
}