using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationOneToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("anik", "123", "an@gmail.com");
            Student student2 = new Student("hasan", "453", "ha@gmail.com");
            Student student3 = new Student("nafi", "666", "na@gmail.com");
            Student student4 = new Student("safi", "666", "sa@gmail.com");
            Department department = new Department("Computer science", "Dhanmondi", "Cse");

            department.AddStudent(student1);
            
            department.AddStudent(student2);
          
            department.AddStudent(student3);
            
            department.AddStudent(student4);
           
            //department.Students.Add(student1);
            //department.Students.Add(student2);
            //department.Students.Add(student3);
            Console.WriteLine("Department Name: "+department.Name + " " +"Location: "+ department.Location + " " +"Code"+ department.Code + "\n");
            foreach (Student student in department.Students)
            {
                string data = "Name: " + student.Name + " " + "Reg NO: " + student.RegNo + " " + "Email: " + student.Email;
               Console.WriteLine(data);
            }
            Console.ReadKey();


        }
    }
}
