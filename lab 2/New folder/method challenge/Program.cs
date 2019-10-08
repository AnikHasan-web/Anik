using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodChallangeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = Console.ReadLine();
            string mName = Console.ReadLine();
            string lName = Console.ReadLine();

            string FullName = GetFullName(fName, mName, lName);

            Console.WriteLine(FullName);

            xyz(5);
        }

        static string GetFullName(string firstName, string middleName, string lastName)
        {

            string FullName = firstName+" " + middleName + " " + lastName;
            int age = 30;

            return FullName;

        }

        static string xyz(int i)
        {
            if (i >= 40)
            {
                return "Passed";
            }

            return "Failed";
        }
    }
}
