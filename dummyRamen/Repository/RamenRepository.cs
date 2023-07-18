using dummyRamen.Factory;
using dummyRamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Repository
{
    public class RamenRepository
    {
        static Database1Entities db = new Database1Entities();

        public static void InsertCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static string addRamen(string name, string meatId, string broth, string price)
        {
            Database1Entities db = new Database1Entities();
            Ramen ramen = RamenFactory.addRamen(name, meatId, broth, price);
            db.Ramen1.Add(ramen);
            db.SaveChanges();
            return "Success!";
        }
        public static List<RamenView> displayRamen()
        {
            Database1Entities db = new Database1Entities();
            List<Ramen> ramens = new List<Ramen>();
            List<RamenView> vramen = new List<RamenView>();
            ramens = db.Ramen1.ToList<Ramen>();
            foreach (Ramen x in ramens)
            {
                Meat meat = new Meat();
                meat = (from y in db.Meats where x.Meatid == y.Id select y).FirstOrDefault();
                RamenView v = new RamenView(x.Id.ToString(), x.Name, meat.name, x.Borth, x.Price.ToString());
                vramen.Add(v);
            }
            return vramen;
        }

        public static void Update(int id, int meatid, string name, string borth, string price)
        {
            Database1Entities db = new Database1Entities();
            Ramen ramen = db.Ramen1.Find(id);
            ramen.Id = id;
            ramen.Meatid = meatid;
            ramen.Name = name;
            ramen.Borth = borth;
            ramen.Price = price;
            db.SaveChanges();
        }

        public static List<Ramen> GetRamen()
        {
            return db.Ramen1.ToList();
        }

        public static Ramen GetRamenId(int id)
        {
            return (from r in db.Ramen1 where r.Id.Equals(id) select r).FirstOrDefault();
        }

        public static void DeleteRamen(int id)
        {
            Database1Entities db = new Database1Entities();
            Ramen ramen = db.Ramen1.Find(id);

            db.Ramen1.Remove(ramen);
            db.SaveChanges();
        }
    }
}