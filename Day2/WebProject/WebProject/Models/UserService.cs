using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WebProject.Models
{
    public class UserService
    {
        
        public List<User> GetUser()
        {
            var users = new UserContext();
            return users.Users;
        }

        public async Task AddUserAsync(User user)
        {
            using (var context = new UserContext())
            {
                if (!context.Users.Contains(user))
                {
                    await Task.Run(() => context.Users.Add(user));
                    //context.Users.Add(user);
                }
            }
        }
    }
}