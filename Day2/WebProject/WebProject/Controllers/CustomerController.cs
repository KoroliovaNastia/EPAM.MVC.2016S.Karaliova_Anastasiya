using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class CustomerController : Controller
    {
        private UserService service = new UserService();

        [HttpPost]
        [ActionName("Add-User")]
        public async Task<ActionResult> Add()
        {
            User user = new User
            {
                
                    Id =3,
                    FirstName = "Anna",
                    LastName = "Rich",
                    Gender = Gender.Famale
               
            };

            await Task.Run(() => service.AddUserAsync(user));

            return RedirectToAction("User-List", service.GetUser());
        }

        [HttpGet]
        [ActionName("User-List")]
        public ActionResult List(List<User> users)
        {

            return View("User-List", users);
        }

        [HttpPost]
        [ActionName("User-List")]
        public JsonResult UserList()
        {
            return Json("Users", JsonRequestBehavior.AllowGet);
        }
       
    }
}