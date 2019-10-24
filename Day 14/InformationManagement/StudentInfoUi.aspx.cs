using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Configuration;
using InformationManagement.BLL;
using InformationManagement.Models;

namespace InformationManagement
{
    public partial class StudentInfoUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowAllStudentInfo();
        }

       

        protected void saveButton_Click(object sender, EventArgs e)
        {
            StudentManager manager=new StudentManager();
            string name = inputStudentName.Value;
            string regNo = inputRegNo.Value;
            string email = inputEmailAddress.Value;
            string mobileNo = inputMobileNo.Value;
            int age = Convert.ToInt32(inputAge.Value);
            string address = inputAddess.Value;
            Student student = new Student(name, regNo, email, mobileNo, age, address);

            messageLabel.Text = manager.SaveStudent(student);

        }

       

        private void ShowAllStudentInfo()
        {
            List<Student> studentList = new List<Student>();
            string connectionString =WebConfigurationManager.ConnectionStrings["IMDB"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Student_tbl";;
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int studentId = (int)reader["StudentId"];
                string studentName = reader["StudentName"].ToString();
                string regNo = reader["RegNo"].ToString();
                string email = reader["Email"].ToString();
                string mobileNo = reader["MobileNo"].ToString();               
                int age = (int)reader["Age"];
                string address = reader["Address"].ToString();
                Student student = new Student(studentName,regNo,email,mobileNo,age,address);
                student.StudentId = studentId;
                studentList.Add(student);
            }
            reader.Close();
            connection.Close();
            StudentGrirdView.DataSource = studentList;
            StudentGrirdView.DataBind();

        }
        protected void ClearField()
        {
            inputStudentName.Value=String.Empty;
            inputRegNo.Value=String.Empty;
            inputEmailAddress.Value=String.Empty;
            inputMobileNo.Value=String.Empty;
            inputAge.Value=String.Empty;
            inputAddess.Value=String.Empty;
        }
    }
}