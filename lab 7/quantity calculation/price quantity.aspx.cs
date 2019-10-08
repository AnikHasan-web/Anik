using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quantity_calculation
{
    public partial class price_quantity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calButton_Click(object sender, EventArgs e)
        {
            double unit = Convert.ToDouble(unitTextBox.Text);
            //ViewState["unitPrice"] = unit;
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            //ViewState["totalQuantity"] =quantity;
            Double totalPrice = unit * quantity;
            ViewState["TotalPrice"] = totalPrice;
            unitTextBox.Text = "";
            quantityTextBox.Text = "";
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
           
            priceTextBox.Text = ViewState["TotalPrice"].ToString();
        }
    }
}