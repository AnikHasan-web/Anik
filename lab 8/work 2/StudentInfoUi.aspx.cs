using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace work_2
{
    public partial class work_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            ClearLabel();
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(userNameTextBox.Text) || string.IsNullOrEmpty(regTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(ageTextBox.Text))
            {
                messageLabel.Text = string.Empty;
                messageLabel.Text = "Please fill up the text field";
                messageLabel.ForeColor = Color.Red;
            }
            else
            {
                Student aStudent = new Student();
                
                aStudent.count = 0;
                aStudent.Email = emailTextBox.Text;
                foreach (char c in aStudent.Email)
                {
                    if (c == '@')
                    {
                        aStudent.count++;
                    }
                        
                }
                    
                //if (aStudent.Email.Contains("@"))
                //{
                //    aStudent.count++;
                //}

                if ((aStudent.count == 1) && (aStudent.Email.Contains(".")))
                {
                    aStudent.FirstName = firstNameTextBox.Text;
                    aStudent.LastName = lastNameTextBox.Text;
                    aStudent.UserName = userNameTextBox.Text;
                    aStudent.Reg = regTextBox.Text;
                    aStudent.Email = emailTextBox.Text;
                    aStudent.Age = Convert.ToInt32(ageTextBox.Text);

                    ViewState["Student"] = aStudent;
                    ClearTextBox();

                    messageLabel.Text = string.Empty;
                    messageLabel.Text = "Student Info Saved";
                    messageLabel.ForeColor = Color.Green;
                }
                else
                {   
                    emailTextBox.Text = string.Empty;
                    emailShowLabel.Text = "Please insert valid email with one @ and at least one . ";
                    emailShowLabel.ForeColor = Color.Red;
                }

            }
            
        }
        private void ClearLabel()
        {
            firstNameLabel.Text = string.Empty;
            lastNameLabel.Text = string.Empty;
            userNameLabel.Text = string.Empty;
            regLabel.Text = string.Empty;
            emailLabel.Text = string.Empty;
            ageLabel.Text = string.Empty;
            emailShowLabel.Text = string.Empty;
        }

        private void ClearTextBox()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            userNameTextBox.Text = string.Empty;
            regTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            ageTextBox.Text = string.Empty;
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            ClearLabel();
            Student viewStudent=new Student();
            viewStudent = (Student) ViewState["Student"];
            if (viewStudent != null)
            {
                firstNameLabel.Text = viewStudent.FirstName;
                lastNameLabel.Text = viewStudent.LastName;
                userNameLabel.Text = viewStudent.UserName;
                regLabel.Text = viewStudent.Reg;
                emailLabel.Text = viewStudent.Email;
                ageLabel.Text = viewStudent.Age.ToString();
                fullNameLabel.Text = viewStudent.GetFullName();

                messageLabel.Text = string.Empty;
                messageLabel.Text = "Student Info Found";
                messageLabel.ForeColor = Color.Green;
            }
            else
            {
                messageLabel.Text = string.Empty;
                messageLabel.Text = "Student Info Not Found";
                messageLabel.ForeColor = Color.Red;
            }
        }

        protected void studentListButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentListUi.aspx");
        }
    }
}