using dummyRamen.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dummyRamen.View
{
	public partial class OrderQueueStaff : System.Web.UI.Page
	{
        protected void Refresh()
        {
            GridView1.DataSource = TransactionController.getUnhandledTransaction();
            GridView1.DataBind();

            GridView2.DataSource = TransactionController.getHandledTransaction();
            GridView2.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["userInfo"];

            if (cookie == null)
            {
                Response.Redirect("~/View/Login.aspx");
            }

            Refresh();
        }

    }
}