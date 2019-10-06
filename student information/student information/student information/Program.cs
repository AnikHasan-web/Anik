using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_information
{
    class Program
    {
        class Student
        {
            public string regNo;
            public string lastName;
            public string firstName;
            public string GetFullName()
            {
                return firstName + " " + lastName;
            }
        }

        static void Main(string[] args)
        {
            Student[] students = new Student[3];

            Student student1 = new Student();
            student1.regNo = "8734";
            student1.firstName = "Rakib";
            student1.lastName = "Hasan";

            Student student2 = new Student();
            student2.regNo = "37654";
            student2.firstName = "Sultana";
            student2.lastName = "Shimi";

            Student student3 = new Student();
            student3.regNo = "5623";
            student3.firstName = "Milon";
            student3.lastName = "Borua";

            students[0] = student1;
            students[1] = student2;
            students[2] = student3;

            foreach (Student aStudent in students)
            {
                Console.WriteLine("Reg: "+aStudent.regNo +"     || "+ "Name: "+ " " + aStudent.GetFullName());
            }

            Console.ReadKey();
        }
    }
}
 n