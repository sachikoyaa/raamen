using dummyRamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Factory
{
    public class CartFactory
    {
        public static Cart addCart(int id, int meatid, string name, string borth, string price)
        {
            Cart cart = new Cart();
            cart.Id = id;
            cart.MeatId = meatid;
            cart.Name = name;
            cart.Borth = borth;
            cart.Price = price;

            return cart;
        }
    }
}