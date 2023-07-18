using dummyRamen.Model;
using dummyRamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dummyRamen.View
{
    public partial class EditRamen : System.Web.UI.Page
    {
        static Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Ramen> ramenList = RamenRepository.GetRamen();
            editRamenGV.DataSource = ramenList;
            editRamenGV.DataBind();
        }

        protected void editRamenGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // Check if the index is within the valid range
            if (e.NewEditIndex >= 0 && e.NewEditIndex < editRamenGV.Rows.Count)
            {
                // Get the id from the selected row
                int id;
                if (int.TryParse(editRamenGV.Rows[e.NewEditIndex].Cells[1].Text, out id))
                {
                    // Redirect to the updateRamen.aspx page with the id as a query parameter
                    Response.Redirect("updateRamen.aspx?id=" + id);
                }
            }
        }

        protected void BackToHomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }
    }
}