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
        [HttpGet]
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

        [HttpPost]

        public ActionResult Index(Person unit)
        {
           
            return View(unit);
        }


        public ActionResult Footer()
        {
            return View();
        }

        //[HttpGet]
        //public ActionResult JoinSide()
        //{
        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        public ActionResult JoinSide(Person person)
        {
            if (person.Side == Side.Light)
            {
                person.Side = Side.Dark;
            }
            else {
                RedirectToAction("Lol");
            }
             return RedirectToAction("Index", person); 
         }

        public ActionResult Lol()
        {
            return View();
        }
    }
}