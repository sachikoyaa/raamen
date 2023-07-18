using dummyRamen.Handler;
using dummyRamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Controller
{
    public class RamenController
    {
        public static List<Ramen> GetRamen()
        {
            return RamenHandler.GetRamen();
        }
        public static string addRamen(string name, string meatId, string broth, string price)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(meatId) || string.IsNullOrEmpty(broth) || string.IsNullOrEmpty(price))
                return "Please fill all the fields!";

            if (!name.Contains("Ramen"))
                return "Ramen name must contain 'Ramen'";

            if (!int.TryParse(price, out int parsedPrice) || parsedPrice < 3000)
                return "Minimum price is 3000";

            return RamenHandler.addRamen(name, meatId, broth, price);
        }

        public static Ramen getRamenById(int id)
        {
            return RamenHandler.getRamenId(id);
        }

        public static bool UpdateRamen(Ramen ramen)
        {
            using (Database1Entities db = new Database1Entities())
            {
                Ramen exRamen = db.Ramen1.Find(ramen.Id);

                if (exRamen != null)
                {
                    exRamen.Name = ramen.Name;
                    exRamen.Meatid = ramen.Meatid;
                    exRamen.Borth = ramen.Borth;
                    exRamen.Price = ramen.Price;

                    db.SaveChanges();

                    return true;
                }
            }

            return false; // Update failed
        }
        public static void DeleteRamen(int id)
        {
            RamenHandler.DeleteRamen(id);
        }

    }
}