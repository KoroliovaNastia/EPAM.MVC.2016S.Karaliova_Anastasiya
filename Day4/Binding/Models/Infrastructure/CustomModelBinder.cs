using Models.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models.Infrastructure
{
    public class CustomModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext modelBindingExecutionContext, ModelBindingContext bindingContext)
        {
            Person model = (Person)bindingContext.Model ?? new Person();
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime dateValue;
            model.FirstName = GetValue(bindingContext, "FirstName");
            model.LastName = GetValue(bindingContext, "LastName");
            var role = GetValue(bindingContext, "Role");
            model.Role = Role.Admin;
            if (role == "<not-defined>")
            {
                model.Role = Role.Guest;
            }
            else if (role == "User")
            {
                model.Role = Role.User;
            }
           
            DateTime.TryParseExact(GetValue(bindingContext, "BirthDate"), "g", enUS,
                                 DateTimeStyles.None, out dateValue);

            model.BirthDate = dateValue;
            //model.BirthDate = DateTime.Parse(GetValue(bindingContext, "BirthDate")) ?? DateTime.;
            //model.HomeAddress.Line1 = GetValue(bindingContext, "Line1");
            //model.HomeAddress.Line2 = GetValue(bindingContext, "Line2");
            //model.HomeAddress.PostalCode = GetValue(bindingContext, "PostalCode");
            //model.HomeAddress.City = GetValue(bindingContext, "City");
            //model.HomeAddress.Country = GetValue(bindingContext, "Country");
            model.HomeAddress.Line1 = GetValue(bindingContext, "Line1");
            model.HomeAddress.Line2 = GetValue(bindingContext, "Line2");
            model.HomeAddress.PostalCode = GetValue(bindingContext, "PostalCode");
            model.HomeAddress.City = GetValue(bindingContext, "City");
            model.HomeAddress.Country = GetValue(bindingContext, "Country");
            model.HomeAddress.AddressSummary = GetAddressSummary(model.HomeAddress);
            return model;
        }

        private string GetValue(ModelBindingContext context, string name)
        {
            name = (context.ModelName == "" ? "" : context.ModelName + ".") + name;

            ValueProviderResult result = context.ValueProvider.GetValue(name);

            if (result == null || result.AttemptedValue == "")
            {
                return "<not-defined>";
            }

            if ((name.Contains("Line1") || name.Contains("Line2")) && result.AttemptedValue.Contains("PO BOX"))
            {
                return "<not-defined>";
            }

            if (name.Contains("PostalCode") && result.AttemptedValue.Length < 6)
            {
                return "<not-defined>";
            }
            return result.AttemptedValue;
        }

        private string GetAddressSummary(Address address)
        {
            if (address.PostalCode == "<not-defined>" || address.City == "<not-defined>" || address.Line1 == "<not-defined>")
                return "No personal address";
            return address.PostalCode + address.City + ", " + address.Line1;
        }
    }
}