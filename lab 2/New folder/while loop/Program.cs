using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0 ;
           while(true)
            {
                i++;
                if (i == 100)
                {
                    break;
                }
                if (i%2==0)
                {

                    
                    continue;
                }
               
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
