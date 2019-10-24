using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
            string name = inputStudentName.Value;
            string regNo = inputRegNo.Value;
            string email = inputEmailAddress.Value;
            string mobileNo = inputMobileNo.Value;
            int age = Convert.ToInt32(inputAge.Value);
            string address = inputAddess.Value;
            Student student = new Student(name, regNo, email, mobileNo, age, address);

            string connectionString =
                @"Server = BITM-TRAINER-30\SQLEXPRESS;Database = InformationManagementDB;Integrated Security=true;";
            var rowEffect = InsertStudentInfo(connectionString, student);

            if (rowEffect > 0)
            {
                messageLabel.Text = String.Empty;
                messageLabel.Text = "Student Information Saved";
                messageLabel.ForeColor = Color.Green;
                ClearField();
                ShowAllStudentInfo();
            }
            else
            {
                messageLabel.Text = String.Empty;
                messageLabel.Text = "Failed to save";
                messageLabel.ForeColor = Color.Red;
            }

        }

        private int InsertStudentInfo(string connectionString, Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO " +
                           "Student_tbl(StudentName, RegNo," +
                           " Email, MobileNo, Age, Address)" +
                           "VALUES('" + student.StudentName + "','" + student.RegNo + "'," +
                           "'" + student.EmailAddress + "','" + student.MobileNo + "'," +
                           "" + student.Age + ",'" + student.Address + "')";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();
            return rowEffect;
        }

        private void ShowAllStudentInfo()
        {
            List<Student> studentList = new List<Student>();
            string connectionString =
                @"Server = BITM-TRAINER-30\SQLEXPRESS;Database = InformationManagementDB;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Student_tbl";
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