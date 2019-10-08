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
            
            Console.WriteLine("enter array value:");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] nameList = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter name:");
                nameList[i]=Console.ReadLine();
                
                
            }

	    Console.WriteLine("--------------------");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(" name:"+nameList[i]);
               
            }

            Console.ReadKey();
        }
    }
}
