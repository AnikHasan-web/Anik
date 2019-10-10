using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace work_2
{
    public partial class Student_List_Ui : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(userNameTextBox.Text) || string.IsNullOrEmpty(regTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(ageTextBox.Text))
            {
                messageLabel.Text = string.Empty;
                messageLabel.Text = "Please fill up the text field";
                messageLabel.ForeColor = Color.Red;
            }
            else
            {

                List<Student> studentList = new List<Student>();
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

                    if (ViewState["AllStudent"] != null)
                    {
                        studentList = (List<Student>)ViewState["AllStudent"];
                    }
                    studentList.Add(aStudent);
                    ViewState["AllStudent"] = studentList;

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

        protected void showButton_Click(object sender, EventArgs e)
        {
            studentListBox.Items.Clear();
            List<Student> viewStudents = new List<Student>();
            viewStudents = (List<Student>)ViewState["AllStudent"];
            if (viewStudents != null)
            {
                foreach (Student data in viewStudents)
                {
                    studentListBox.Items.Add("First Name :" + data.FirstName);
                    studentListBox.Items.Add("last Name :" + data.LastName);
                    studentListBox.Items.Add("User Name :" + data.UserName);
                    studentListBox.Items.Add("Reg No :" + data.Reg);
                    studentListBox.Items.Add("Email :" + data.Email);
                    studentListBox.Items.Add("Age :" + data.Age);
                    studentListBox.Items.Add("Full Name :" + data.GetFullName());
                    studentListBox.Items.Add(" ");

                    messageLabel.Text = string.Empty;
                    messageLabel.Text = "Student Info Found";
                    messageLabel.ForeColor = Color.Green;
                }
            }
            else
            {
                messageLabel.Text = String.Empty;
                messageLabel.Text = "Student Info Not Found";
                messageLabel.ForeColor = Color.Red;
            }
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
    }
}
