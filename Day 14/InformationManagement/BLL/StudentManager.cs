using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InformationManagement.DAL;
using InformationManagement.Models;

namespace InformationManagement.BLL
{
    public class StudentManager
    {
        public  string SaveStudent(Student student)
        {
            StudentGateway gateway=new StudentGateway();
            Student aStudent = gateway.GetExistStudent(student);
            if (aStudent != null)
            {
                return "Registration number already exist.Please enter unique reg no";
            }

            bool isSaved = gateway.SaveStudent(student);
            if (isSaved)
            {
                return "Student saved successfully";
            }
            else
            {
                return "Save Failed";
            }


        }
    }
}