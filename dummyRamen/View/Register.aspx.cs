using dummyRamen.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dummyRamen.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void regisBtn_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            string email = emailadd.Text;
            string gender = gen.Text;
            string password = pass.Text;

            UserController.insertUser(username, 3, email, gender, password);

            Response.Redirect("Login.aspx");
        }
    }
}