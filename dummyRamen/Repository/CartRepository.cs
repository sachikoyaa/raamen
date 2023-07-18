using dummyRamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Repository
{
    public class CartRepository
    {
        static Database1Entities db = new Database1Entities();
        public static List<Cart> GetCartItem()
        {
            return db.Carts.ToList();
        }

        public static void InsertCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
        }

    }
}