using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyRamen.Model
{
	public class CartItem
	{
		public int RamenId { get; set; }
		public string RamenName { get; set; }
		public int RamenPrice { get; set; }
		public int Quantity { get; set; }
	}
}