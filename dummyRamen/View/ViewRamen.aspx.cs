using dummyRamen.Controller;
using dummyRamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dummyRamen.View
{
    public partial class ViewRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gv.DataSource = RamenRepository.GetRamen();
            gv.DataBind();
        }

        protected void addToCartBtn_Click(object sender, EventArgs e)
        {
            // Get the selected ramen details
            Button addToCartBtn = (Button)sender;
            GridViewRow row = (GridViewRow)addToCartBtn.NamingContainer;
            int id = Convert.ToInt32(gv.DataKeys[row.RowIndex].Value);
            int meatId = Convert.ToInt32(gv.Rows[row.RowIndex].Cells[1].Text);
            string name = gv.Rows[row.RowIndex].Cells[2].Text;
            string broth = gv.Rows[row.RowIndex].Cells[3].Text;
            string price = gv.Rows[row.RowIndex].Cells[4].Text;

            CartController.AddToCart(id, meatId, name, broth, price);
        }

        protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                // Retrieve the values from the GridView cells in the clicked row
                int Id = Convert.ToInt32(gv.Rows[rowIndex].Cells[0].Text);
                int Meatid = Convert.ToInt32(gv.Rows[rowIndex].Cells[1].Text);
                string Name = gv.Rows[rowIndex].Cells[2].Text;
                string Borth = gv.Rows[rowIndex].Cells[3].Text;
                string Price = gv.Rows[rowIndex].Cells[4].Text;

                CartController.AddToCart(Id, Meatid, Name, Borth, Price);
            }
        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfileEdit.aspx");
        }

        protected void LogOutBtn_Click(object sender, EventArgs e)
        {
            // Clear the session variables
            Session.Clear();

            // Clear authentication cookies
            Response.Cookies.Clear();

            // Redirect the user to the login page
            Response.Redirect("Login.aspx");
        }
    }
}