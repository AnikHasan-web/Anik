using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("goto method anik");
            Anik();
            Console.ReadKey();

            
        }
        static void Anik()
        {
           
            Console.WriteLine("welcome to my new work about dot net!");
            string name = Console.ReadLine();
            string age = Console.ReadLine();
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age" +age);
            Console.ReadKey();

             
        }
    }
}
