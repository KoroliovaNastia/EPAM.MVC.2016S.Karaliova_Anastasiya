using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class UserContext : IDisposable
    {
        public List<User> Users { get; set; }

        public UserContext()
        {
            Users = new List<User>
            {
                new User
                {
                    Id =0,
                    FirstName = "Anna",
                    LastName = "Rich",
                    Gender = Gender.Famale
                },

                new User
                {
                    Id =1,
                    FirstName = "Nick",
                    LastName = "Robins",
                    Gender = Gender.Male
                },

                new User
                {
                    Id =2,
                    FirstName = "Frik",
                    LastName = "Uoker",
                    Gender = Gender.Male
                }
            };
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}