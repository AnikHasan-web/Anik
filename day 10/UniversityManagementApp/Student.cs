﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementApp
{
    public class Student
    {
        public int StudentId { get; set; }
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        //public Student(string regNo, string name, string email, string phone)
        //{
        //    RegNo = regNo;
        //    Name = name;
        //    Email = email;
        //    Phone = phone;

        //}
    }
}