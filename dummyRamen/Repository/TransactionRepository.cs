using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dummyRamen.Factory;
using dummyRamen.Model;

namespace dummyRamen.Repository
{
	public class TransactionRepository
	{
        public static int createHeader(string customerId)
        {
            Database1Entities db = new Database1Entities();

            Header header = HeaderFactory.createHeader(customerId);
            db.Headers.Add(header);
            db.SaveChanges();

            return header.Id;
        }

        public static string createDetails(int headerId, int ramenId, int quantity)
        {
            Database1Entities db = new Database1Entities();
            Detail detail = DetailFactory.createDetail(headerId, ramenId, quantity);
            db.Details.Add(detail);
            db.SaveChanges();

            return "details added";
        }

        public static List<Header> getHeader(int customerId)
        {
            Database1Entities db = new Database1Entities();
            List<Header> transaction = (from t in db.Headers where t.CustomerId.Equals(customerId) select t).ToList();

            return transaction;
        }

        public static List<Header> getUnhandledTransaction()
        {
            Database1Entities db = new Database1Entities();
            List<Header> unhandled = (from t in db.Headers where (t.Staffid.Equals(null)) select t).ToList();

            return unhandled;
        }

        public static List<Header> getHandledTransaction()
        {
            Database1Entities db = new Database1Entities();
            List<Header> handled = (from t in db.Headers select t).ToList();

            return handled;
        }

        public static string handleTransaction(int headerId, int Id)
        {
            Database1Entities db = new Database1Entities();

            Header header = db.Headers.Find(headerId);

            header.Staffid = Id;
            
            db.SaveChanges();

            return "success";
        }
        public static List<Header> getAllTransactions()
        {
            Database1Entities db = new Database1Entities();
            return db.Headers.ToList();
        }
    }
}