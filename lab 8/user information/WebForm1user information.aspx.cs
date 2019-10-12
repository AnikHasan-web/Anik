using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace user_information
{
    public partial class WebForm1user_information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            
            ViewState["first name"] = firstNameTextBox.Text;
            ViewState["last name"] = lastNameTextBox.Text;
            ViewState["user name"] = userNameTextBox.Text;
            ViewState["reg no"] = regNumberTextBox.Text;
            ViewState["email"] = emailTextBox.Text;
            ViewState["age"] = Convert.ToInt32(ageTextBox.Text);
            firstNameTextBox.Text = " ";
            lastNameTextBox.Text = " ";
            userNameTextBox.Text = " ";
            regNumberTextBox.Text = " ";
            emailTextBox.Text = " ";
            ageTextBox.Text = " ";

            showLabel.Text = string.Empty;
            showLabel.Text = "Student Info Saved";
            showLabel.ForeColor = Color.Green;

        }

        protected void showButton_Click(object sender, EventArgs e)
        {

            Label7.Text = ViewState["first name"].ToString();
            Label8.Text = ViewState["last name"].ToString();
            Label9.Text = ViewState["user name"].ToString();
            Label10.Text = ViewState["reg no"].ToString();
            Label11.Text = ViewState["email"].ToString();
            Label12.Text = ViewState["age"].ToString();


            showLabel.Text = string.Empty;
            showLabel.Text = "Student Info Found";
            showLabel.ForeColor = Color.Red;
        }
    }
}
