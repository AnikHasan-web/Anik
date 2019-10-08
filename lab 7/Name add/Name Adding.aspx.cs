using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Name_add
{
    public partial class Name_Adding : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            ViewState["name"] = nameTextBox.Text;
            nameTextBox.Text = "";

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
           
            showLabel.Text = ViewState["name"].ToString();
            
        }
    }
}