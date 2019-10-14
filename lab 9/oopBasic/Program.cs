using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oopBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.firstName = "Md";
            person1.middleName = "Anik";
            person1.lastName = "Hasan";
            GetChange(person1);
            string fullName = person1.GetFullName();
            string reverseName = person1.GetReverseName();
            Console.WriteLine("Full Name: "+fullName);
            Console.WriteLine("Reverse Name: " + reverseName+"\n");
            
            Console.WriteLine("--------------------------------------"+"\n");


            Person person2=new Person();
            person2.firstName = "Md";
            person2.middleName = "Adorsha";
            person2.lastName = "Hasan";
            fullName = person2.GetFullName();
            reverseName = person2.GetReverseName();
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Full Name: " + reverseName+"\n");

            Console.WriteLine("--------------------------------------"+"\n");

            Person person3=new Person();
            person3 = person2;
            person2.lastName = "Hossain";
            fullName = person2.GetFullName();
            reverseName = person2.GetReverseName();
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Full Name: " + reverseName);

            Console.ReadKey();

        }

        static void GetChange(Person person)
        {
            person.lastName = "Changed";
        }

    }
}
