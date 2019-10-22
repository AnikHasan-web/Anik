using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationOneToMany
{
    class Student
    {
        public Student()
        {
        }

        public Student(string name, string regNo, string email)
        :this()
        {
            Name = name;
            RegNo = regNo;
            Email = email;
        }

        public string Name { set; get; }
        public string RegNo { set; get; }
        public string Email { set; get; }
        
    }
}
