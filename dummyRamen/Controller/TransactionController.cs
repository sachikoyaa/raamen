using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dummyRamen.Handler;
using dummyRamen.Model;

namespace dummyRamen.Controller
{
	public class TransactionController
	{
        public static string createTransaction(List<CartItem> cart, string customerId)
        {
            if (cart == null)
            {
                return "Cart is empty";
            }
            else
            {
                return TransactionHandler.createTransaction(cart, customerId);
            }
        }

        public static List<Header> getHeader(int customerId)
        {
            return TransactionHandler.getHeader(customerId);
        }

        public static List<Header> getUnhandledTransaction()
        {
            return TransactionHandler.getUnhandledTransaction();
        }

        public static List<Header> getHandledTransaction()
        {
            return TransactionHandler.getHandledTransaction();
        }

        public static string handleTransaction(int headerId, int Id)
        {
            return TransactionHandler.handleTransaction(headerId, Id);
        }
    }
}