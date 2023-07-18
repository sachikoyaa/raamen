using dummyRamen.Controller;
using dummyRamen.Model;
using dummyRamen.Repository;
using dummyRamen.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dummyRamen.View
{
    public partial class ManageRamen : System.Web.UI.Page
    {
        protected void Refresh()
        {
            RamenGV.DataSource = RamenController.GetRamen();
            RamenGV.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<RamenView> ramens = RamenRepository.displayRamen();
            RamenGV.DataSource = ramens;
            RamenGV.DataBind();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddRamen.aspx");
        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditRamen.aspx");
        }

		protected void RamenGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
		{
            GridViewRow row = RamenGV.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[1].Text);
            RamenController.DeleteRamen(id);
            Refresh();

        }
	}
}