using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Data;
using Models.Models;

namespace Models.Controllers
{
    public class HomeController : Controller
    {
	    private readonly IPersonRepo _repo;

	    public HomeController(IPersonRepo personRepo)
	    {
		    _repo = personRepo;
	    }

        public ActionResult Index(FormCollection formData)
        {
            IList<Person> persons = new List<Person>();
            UpdateModel(persons, formData);
            return View(persons);
        }
        public ActionResult CreatePerson()
        {
            return View(new Person());
        }

        //[HttpPost]
        //public ActionResult CreatePerson(Person model)
        //{
        //    return View("Index", model);
        //}

        public ActionResult DisplaySummary([Bind(Prefix = "HomeAddress")]Address summary)
        {
            return View(summary);
        }

        public ActionResult Names(string[] names)
        {
            names = names ?? new string[0];
            return View(names);
        }
        //public ActionResult Address(IList<Address> adresses)
        //{
        //    adresses = adresses ?? new List<Address>();
        //    return View(adresses);
        //}

        public ActionResult Address(FormCollection formData)
        {
            IList<Address> addresses = new List<Address>();
            UpdateModel(addresses, formData);
            return View(addresses);
        }
    }
}