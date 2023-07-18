using dummyRamen.Factory;
using dummyRamen.Model;
using dummyRamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Handler
{
    public class CartHandler
    {
        public static void addCart(int id, int meatid, string name, string borth, string price)
        {
            Cart cart = CartFactory.addCart(id, meatid, name, borth, price);
            RamenRepository.InsertCart(cart);
        }
    }
}