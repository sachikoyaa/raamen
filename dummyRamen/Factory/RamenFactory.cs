using dummyRamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Factory
{
    public class RamenFactory
    {
        Database1Entities db = new Database1Entities();
        public static Ramen addRamen(string name, string meatId, string broth, string price)
        {
            Ramen x = new Ramen();
            x.Name = name;
            x.Meatid = int.Parse(meatId);
            x.Borth = broth;
            x.Price = price;
            return x;
        }
    }
}