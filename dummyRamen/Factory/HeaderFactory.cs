using dummyRamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Factory
{
	public class HeaderFactory
	{
        public static Header createHeader(string customerId)
        {
            Header header = new Header();

            header.CustomerId = int.Parse(customerId);
            header.Staffid = 0;
            header.Date = DateTime.Now.Date;

            return header;
        }
    }
}