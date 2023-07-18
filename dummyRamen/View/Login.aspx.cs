using dummyRamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dummyRamen.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void toRegis_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            string password = pass.Text;

            Database1Entities db = new Database1Entities();
            User user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                // Authentication successful
                Session["Id"] = user.Id;
                Session["Roleid"] = user.Roleid; // Store the user's role in the session

                // Redirect the user based on their role
                if (user.Roleid == 1)
                {
                    Response.Redirect("AdminHome.aspx");
                }
                else if (user.Roleid == 2)
                {
                    Response.Redirect("Homepage.aspx");
                }
                else if (user.Roleid == 3)
                {
                    Response.Redirect("ViewRamen.aspx");
                }
            }
            else
            {
                // Authentication failed
                errorLabel.Text = "Invalid username or password";
            }
        }
    }
}