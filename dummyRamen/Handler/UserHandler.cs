using dummyRamen.Factory;
using dummyRamen.Model;
using dummyRamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Handler
{
    public class UserHandler
    {
        //insert
        public static void insertUser(string username, int roleid, string email, string gender, string password)
        {
            User user = UserFactory.createUser(username, roleid, email, gender, password);
            UserRepository.Insert(user);
        }

        //update
        public static void updateUser(int id, string username, string email, string gender, string password)
        {
            UserRepository.Update(id, username, email, gender, password);
        }

        //get user
        public static User getUser(string username, string password)
        {
            return UserRepository.GetUser(username, password);
        }

        public static User getUserId(int id)
        {
            return UserRepository.GetUserId(id);
        }
        public static List<User> getStaff()
        {
            return UserRepository.getStaff();
        }
        public static List<User> getCustomer()
        {
            return UserRepository.getCustomer();
        }
    }
}