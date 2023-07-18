using dummyRamen.Model;
using dummyRamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Handler
{
    public class RamenHandler
    {
        public static List<Ramen> GetRamen()
        {
            return RamenRepository.GetRamen();
        }
        public static string addRamen(string name, string meatId, string broth, string price)
        {
            return RamenRepository.addRamen(name, meatId, broth, price);
        }

        public static List<RamenView> displayRamen()
        {
            return RamenRepository.displayRamen();
        }

        public static void updateRamen(int id, int meatid, string name, string borth, string price)
        {
            RamenRepository.Update(id, meatid, name, borth, price);
        }

        public static Ramen getRamenId(int id)
        {
            return RamenRepository.GetRamenId(id);
        }

        public static void DeleteRamen(int id)
        {
            RamenRepository.DeleteRamen(id);
        }
    }
}