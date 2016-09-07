using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task_Day_3.Models
{
    public class Person
    {
        public int? Id { get; set; }
        public string PersonName { get; set; }
        public string PersonClass { get; set; }
        public Side Side { get; set; }
    }

    public enum Side
    {
        Light,
        Dark
    }
}