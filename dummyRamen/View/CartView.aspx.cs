using dummyRamen.Controller;
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
    public partial class CartView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cartgv.DataSource = CartRepository.GetCartItem();
            Cartgv.DataBind();

            GridView1.DataSource = RamenController.GetRamen();
            GridView1.DataBind();
        }

		protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
		{
            GridViewRow row = GridView1.Rows[e.NewSelectedIndex];
            int id;
			int.TryParse(GridView1.Rows[e.NewSelectedIndex].Cells[1].Text, out id);
			var meatId = int.Parse(row.Cells[2].Text);
			var name = row.Cells[3].Text;
			var borth = row.Cells[4].Text;
			var price = row.Cells[5].Text;

			CartController.AddToCart(id, meatId, name, borth, price);

            Cartgv.DataSource = CartRepository.GetCartItem();
            Cartgv.DataBind();

            GridView1.DataSource = RamenController.GetRamen();
            GridView1.DataBind();
        }
	}
}