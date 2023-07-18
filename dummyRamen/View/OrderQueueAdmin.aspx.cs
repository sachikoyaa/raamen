using dummyRamen.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dummyRamen.View
{
	public partial class OrderQueue : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			GridView1.DataSource = TransactionController.getUnhandledTransaction();
			GridView1.DataBind();

			GridView2.DataSource = TransactionController.getHandledTransaction();
			GridView2.DataBind();
		}

		protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
		{
			GridViewRow row = GridView1.Rows[e.NewEditIndex];
			int transaction = int.Parse(row.Cells[1].Text);

			TransactionController.handleTransaction(transaction, Convert.ToInt32(Session["Id"]));
			GridView1.DataSource = TransactionController.getUnhandledTransaction();
			GridView1.DataBind();

			GridView2.DataSource = TransactionController.getHandledTransaction();
			GridView2.DataBind();
		}
	}
}