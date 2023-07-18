using dummyRamen.Handler;
using dummyRamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Controller
{
    public class UserController
    {
        //insert
        public static void insertUser(string username, int roleid, string email, string gender, string password)
        {
            UserHandler.insertUser(username, roleid, email, gender, password);
        }

        //update
        public static void updateUser(int id, string username, string email, string gender, string password)
        {
            //validasi
            UserHandler.updateUser(id, username, email, gender, password);
        }

        public static User getUser(string username, string password)
        {
            return UserHandler.getUser(username, password);
        }

        public static User getUserById(int id)
        {
            return UserHandler.getUserId(id);
        }

        public static List<User> getStaff()
        {
            return UserHandler.getStaff();
        }

        public static List<User> getCustomer()
        {
            return UserHandler.getCustomer();
        }
    }
}