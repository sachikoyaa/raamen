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
    public partial class UpdateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Database1Entities db = new Database1Entities();

            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    Ramen ramen = RamenController.getRamenById(id);

                    if (ramen != null)
                    {
                        name.Text = ramen.Name;
                        addMeatDD.Text = ramen.Meatid.ToString();
                        broth.Text = ramen.Borth;
                        price.Text = ramen.Price;
                    }
                }
            }

        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            Ramen ramen = RamenController.getRamenById(id);

            if (ramen != null)
            {
                ramen.Name = name.Text;
                ramen.Meatid = Convert.ToInt32(addMeatDD.SelectedValue);
                ramen.Borth = broth.Text;
                ramen.Price = price.Text;
                bool updateResult = RamenController.UpdateRamen(ramen);

                if (updateResult)
                {
                    // Update successful
                    Response.Redirect("EditRamen.aspx");
                }
                else
                {
                    // Update failed
                    // You can add an error message or handle the failure as needed
                }
            }
        }

        protected void addBack_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditRamen.aspx");
        }
    }
}