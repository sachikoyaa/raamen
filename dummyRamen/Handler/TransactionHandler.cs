using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dummyRamen.Model;
using dummyRamen.Repository;

namespace dummyRamen.Handler
{
	public class TransactionHandler
	{
        public static string createTransaction(List<CartItem> cart, string customerId)
        {
            int headerId = TransactionRepository.createHeader(customerId);

            if (!headerId.Equals(""))
            {
                foreach (var item in cart)
                {
                    int ramenId = item.RamenId;
                    int quantity = item.Quantity;

                    TransactionRepository.createDetails(headerId, ramenId, quantity);
                }
            }

            return "Transaction success";
        }

        public static List<Header> getUnhandledTransaction()
        {
            return TransactionRepository.getUnhandledTransaction();
        }

        public static List<Header> getHandledTransaction()
        {
            return TransactionRepository.getHandledTransaction();
        }

        public static List<Header> getHeader(int customerId)
        {
            return TransactionRepository.getHeader(customerId);
        }

        public static string handleTransaction(int headerId, int Id)
        {
            return TransactionRepository.handleTransaction(headerId, Id);
        }

        public static List<Header> getAllTransactions()
        {
            return TransactionRepository.getAllTransactions();
        }
    }
}