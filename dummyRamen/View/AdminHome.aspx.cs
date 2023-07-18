using dummyRamen.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dummyRamen.View
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            GridView1.DataSource = UserController.getStaff();
            GridView1.DataBind();

            GridView2.DataSource = UserController.getCustomer();
            GridView2.DataBind();
        }

        protected void ViewReportBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Report.aspx");
        }
    }
}