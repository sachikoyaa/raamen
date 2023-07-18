using dummyRamen.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Controller
{
    public class CartController
    {
        public static void AddToCart(int id, int meatId, string name, string broth, string price)
        {
            CartHandler.addCart(id, meatId, name, broth, price);
        }
    }
}