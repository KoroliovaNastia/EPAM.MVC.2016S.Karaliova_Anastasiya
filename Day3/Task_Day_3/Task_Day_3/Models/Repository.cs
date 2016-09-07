using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task_Day_3.Models
{
    public class Repository
    {
        private static IList<Person> persons;

        public Repository()
        {
            persons = new List<Person>();
            Person unit = new Person
            {
                Id = 0,
                PersonName = "Luke",
                PersonClass = "Jedi",
                Side = Side.Light
            };
            persons.Add(unit);
        }

        public IList<Person> GetAll()
        {
            return persons;
        }

        public Person GetPersonById(int? id)
        {
            return persons.FirstOrDefault(u => u.Id == id);
        }

        public void AddPerson(Person person)
        {
            if(!persons.Contains(person))
            persons.Add(person);
        }

        public void ChangeSide(int personId)
        {
            if(persons[personId].Side == Side.Light)
                persons[personId].Side = Side.Dark;
        }
    }
}