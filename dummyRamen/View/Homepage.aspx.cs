using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dummyRamen.View
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ManageRamenBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRamen.aspx");
        }
    }
}