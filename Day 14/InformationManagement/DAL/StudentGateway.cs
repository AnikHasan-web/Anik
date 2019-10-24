using InformationManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace InformationManagement.DAL
{
    public class StudentGateway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["IMDB"].ConnectionString;

        public bool SaveStudent(Student student)
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
            if(rowEffect>0)
            return true;
            return false;
        }

        

        public Student GetExistStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Student_tbl WHERE RegNo='" + student.RegNo + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Student astudent = null;
            while (reader.Read())
            {
                astudent=new Student();
                astudent.StudentId = Convert.ToInt32(reader["StudentId"]);
                astudent.StudentName = reader["StudentName"].ToString();
                astudent.RegNo = reader["RegNo"].ToString();
                astudent.Address = reader["Address"].ToString();
                astudent.MobileNo = reader["MobileNo"].ToString();
                astudent.Age = Int32.Parse(reader["Age"].ToString());
                astudent.EmailAddress = reader["Email"].ToString();
                
            }
            reader.Close();
            connection.Close();
            return astudent;
        }
    }
    
}