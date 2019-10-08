using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0;
            long l = 4654648;

            l = numberOne; // Implicit Conversion 

            numberOne = Convert.ToInt32(l); // Explicit Converstion 

            //bool a  = false;

            //Console.WriteLine(Convert.ToInt32(a));

            char c = 'a';

            string s = "8";

            Console.WriteLine(Convert.ToInt32(s));

            Console.ReadKey();
        }
    }
}
