using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int i, sum = 0,sum1=0;

            for(i = 1; i <= 100; i++)
                {

                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i <= 10)
                    {
                        Console.WriteLine("Multiple of 3 or 5 from 1 to 10:" + i);
                        sum = sum + i;
                    }
                   // Console.WriteLine("Multiple of 3 or 5 from 1 to 1000:" + i);
                    sum1 = sum1 + i;
                }
               
                }
            Console.WriteLine("sum Multiple of 3 or 5:" + sum);
            Console.WriteLine("sum Multiple of 3 or 5 from 1 to 1000:" + sum1);
            Console.ReadKey();
         
            
        }
    }
}
