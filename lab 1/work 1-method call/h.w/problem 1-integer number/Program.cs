using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i,up, lw;
            up = Convert.ToInt32(Console.ReadLine());
            lw = Convert.ToInt32(Console.ReadLine());
            if (up > lw) {

                for (i = lw; i <= up; i++)
                {

                    Console.WriteLine("Int Number:" + i);
                }

                Console.ReadKey();


            }
            else
            {
                Console.WriteLine("Invalid ");
            }



        }
    }
}