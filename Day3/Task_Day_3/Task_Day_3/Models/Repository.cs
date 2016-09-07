using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task_Day_3.Models
{
    public class Repository
    {
        private IList<Person> persons;

        public Repository()
        {
            persons = new List<Person>();
        }

        public IList<Person> GetAll()
        {
            return persons;
        }

        public Person GetPersonById(int id)
        {
            return persons.FirstOrDefault(u => u.Id == id);
        }

        public void AddPerson(Person person)
        {
            if(!persons.Contains(person))
            persons.Add(person);
        }
    }
}