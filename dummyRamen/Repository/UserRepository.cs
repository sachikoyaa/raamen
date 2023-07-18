using dummyRamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Repository
{
    public class UserRepository
    {
        static Database1Entities db = new Database1Entities();

        // insert
        public static void Insert(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        // update
        public static void Update(int id, string username, string email, string gender, string password)
        {
            User user = db.Users.Find(id);
            user.Username = username;
            user.Email = email;
            user.Gender = gender;
            user.Password = password;
            db.SaveChanges();
        }

        public static User GetUser(string username, string password)
        {
            return (from u in db.Users where u.Username.Equals(username) && u.Password.Equals(password) select u).FirstOrDefault();
        }

        public static User GetUserId(int id)
        {
            return (from u in db.Users where u.Id.Equals(id) select u).FirstOrDefault();
        }

        public static List<User> getStaff()
        {
            Database1Entities db = new Database1Entities();
            List<User> staff = (from x in db.Users where x.Roleid.Equals(1) select x).ToList();

            return staff;
        }

        public static List<User> getCustomer()
        {
            Database1Entities db = new Database1Entities();
            List<User> customer = (from x in db.Users where x.Roleid.Equals(2) select x).ToList();

            return customer;
        }
    }
}
