using dummyRamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Repository
{
    public class MeatRepository
    {
        private static Database1Entities db = new Database1Entities();
        public static List<Meat> displayMeat()
        {

            List<Meat> meats = new List<Meat>();
            meats = db.Meats.ToList<Meat>();
            return meats;
        }
    }
}