using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace work_2
{
    [Serializable]
    public class Student      
    {
        public string FirstName;
        public string LastName;
        public string UserName;
        public string Reg;
        public string Email;
        public int Age;
        public int count;
       
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}