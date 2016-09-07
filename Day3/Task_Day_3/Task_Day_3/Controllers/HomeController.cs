using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_Day_3.Models;

namespace Task_Day_3.Controllers
{
    public class HomeController : Controller
    {
        private Repository repository = new Repository();
        // GET: Home
        public ActionResult Index()
        {
            Person unit = new Person
            {
                Id = 0,
                PersonName = "Luke",
                PersonClass = "Jedi",
                Side = Side.Light
            };
            repository.AddPerson(unit);

            return View(repository.GetPersonById(0));
        }

        public ActionResult Footer()
        {
            return View();
        }

         [HttpGet] 
         public ActionResult JoinSide()
         { 
            return View(); 
         } 
 
 
         [HttpPost] 
         [ValidateAntiForgeryToken] 
         public ActionResult JoinSide(Person person)
        {
            if (person.Side == Side.Light)
            {
                person.Side = Side.Dark;
            }
            else {
                RedirectToAction("Lol");
            }
             return RedirectToAction("Index"); 
         }

        public ActionResult Lol()
        {
            return View();
        }
    }
}