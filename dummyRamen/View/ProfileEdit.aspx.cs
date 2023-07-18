using dummyRamen.Controller;
using dummyRamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dummyRamen.View
{
    public partial class ProfileEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Database1Entities db = new Database1Entities();
                // Retrieve the user ID from the session
                int Id = Convert.ToInt32(Session["Id"]);

                // Retrieve the user details based on the user ID
                User user = UserController.getUserById(Id);

                // Populate the form fields with the user details
                if (user != null)
                {
                    name.Text = user.Username;
                    emailadd.Text = user.Email;
                    gen.Text = user.Gender;
                    pass.Text = user.Password;
                }
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the user ID from the session
            int Id = Convert.ToInt32(Session["Id"]);

            string username = name.Text;
            string email = emailadd.Text;
            string gender = gen.Text;
            string password = pass.Text;

            UserController.updateUser(Id, username, email, gender, password);
            Response.Redirect("ViewRamen.aspx");
        }
    }
}
