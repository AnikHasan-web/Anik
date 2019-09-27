using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string variable
            string firstname;
            string lastname;
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            Console.WriteLine(firstname + " " + lastname);

            int num1 = 5;
            double num2 = 5.7;
            

            Console.WriteLine(num1 + num2);

            int a = Convert.ToInt32(Console.ReadLine());
	    int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);


            int i;
            int c;
            
            for (i = 1; i <= b; i++)
            {
                Console.WriteLine(i);
            }
            for (i = 1; i <= b; i++)
            {

                c = i * b;

            }
            Console.WriteLine(c);
           



            Console.ReadKey();



        }
    }
}
