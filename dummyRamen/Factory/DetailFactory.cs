using dummyRamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Factory
{
	public class DetailFactory
	{
        public static Detail createDetail(int headerId, int ramenId, int quantity)
        {
            Detail detail = new Detail
            {
                HeaderId = headerId,
                Ramenid = ramenId,
                Quantity = quantity
            };

            return detail;
        }
    }
}