using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int upperlimit = Convert.ToInt32(Console.ReadLine());
            int lowerlimit = Convert.ToInt32(Console.ReadLine());
            if (upperlimit > lowerlimit)
            {
                for (i = lowerlimit; i <= upperlimit; i++)
                {

                    if (i % 2 != 0)
                    {
                        Console.WriteLine("Odd:" + i);
                    }
                }
            }
            else
            {
                
                Console.WriteLine("Invalid Input");
            }
            
            Console.ReadKey();

            
        }
    }
}
