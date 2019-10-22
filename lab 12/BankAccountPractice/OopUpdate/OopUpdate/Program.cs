using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Anik", "Hasan");

            //GetChange(person1);
            string fullName = person1.GetFullName();
            string reverseName = person1.GetReverseName();
            person1.personalId = "12345";
            Console.WriteLine("Personal Id: " + person1.personalId);
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Reverse Name: " + reverseName + "\n");
            


            Console.WriteLine("--------------------------------------" + "\n");


            Person person2 = new Person("Md", "Adorsha", "Hasan");
            
            fullName = person2.GetFullName();
            reverseName = person2.GetReverseName();
            person2.personalId = "67890";
            Console.WriteLine("Personal Id: " + person2.personalId);
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Reverse Name: " + reverseName + "\n");
            

            Console.WriteLine("--------------------------------------" + "\n");

            Person person3 = person2;

            person2.LastName = "Hossain";
            fullName = person2.GetFullName();
            reverseName = person2.GetReverseName();
            person3.personalId = "111111";
            Console.WriteLine("Personal Id: " + person3.personalId);
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Reverse Name: " + reverseName);
            

            Console.WriteLine("--------------------------------------" + "\n");

            Console.ReadKey();

        }

        //static void GetChange(Person person)
        //{
        //    person.LastName = "Changed";
        //}
    }
}
