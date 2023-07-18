using dummyRamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Factory
{
    public class UserFactory
    {
        public static User createUser(string username,  int roleid, string email, string gender, string password)
        {
            User user = new User();
            user.Username = username;
            user.Roleid = roleid;
            user.Email = email;
            user.Gender = gender;
            user.Password = password;

            return user;
        }
    }
}