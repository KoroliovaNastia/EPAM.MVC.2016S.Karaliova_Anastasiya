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
        //[HttpGet]
        //public ActionResult Index()
        //{

        //    return View(repository.GetPersonById(0));
        //}

        //[HttpPost]

        public ActionResult Index(Person person)
        {
            if (person.Id == null)
                return View(repository.GetPersonById(0));
            return View(person);
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
        public ActionResult JoinSide(int? personId)
        {
            Person person = repository.GetPersonById(personId);
            if (person.Side == Side.Light)
            {
                repository.ChangeSide((int)personId);
            }
            else {
                RedirectToAction("Lol", person);
            }
             return RedirectToAction("Index", person); 
         }

        public ActionResult Lol(Person person)
        {
            return RedirectToAction("Index");
        }
    }
}