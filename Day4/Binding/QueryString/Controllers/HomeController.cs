using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QueryString.Models;

namespace QueryString.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CultureInfo culture)
        {
            string firstName = Request.QueryString["FirstName"];
            string lastName = Request.QueryString["LastName"];
            //CultureInfo enUS = new CultureInfo("en-US");
            DateTime dateOfBirth; 
            DateTime.TryParseExact(Request.QueryString["BirthDate"], "g", culture,
                                 DateTimeStyles.None, out dateOfBirth);
            Role role = Role.Admin;
            string roleStr = Request.QueryString["Role"];
            if (roleStr == null)
                roleStr = "<not-defined>";
            if(roleStr == "<not-defined>")
                role = Role.Guest;
            if(!Request.IsLocal)
                role = Role.User;

            string line1 = Request.QueryString["Line1"];
            string line2 = Request.QueryString["Line2"];
            string postalCode = Request.QueryString["PostalCode"];
            string city = Request.QueryString["City"];
            string country = Request.QueryString["Country"];
            if (line1 == null || line1.Contains("PO BOX"))
                line1 = "<not-defined>";
            if (line2 == null || line2.Contains("PO BOX"))
                line2 = "<not-defined>";
            if (postalCode == null || postalCode.Length < 6)
                postalCode = "<not-defined>";

            string addressSummary = postalCode + city + "," + line1;
            if (addressSummary.Contains("<not-defined>"))
                addressSummary = "No personal address";

            Person person = new Person()
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = dateOfBirth,
                Role = role,
                HomeAddress = new Address()
                {
                    Line1 = line1,
                    Line2 = line2,
                    City = city,
                    Country = country,
                    PostalCode = postalCode,
                    AddressSummary = addressSummary
                }
            };
            return View(person);
        }
    }
}