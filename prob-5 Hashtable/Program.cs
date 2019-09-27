using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable nameList = new Hashtable();
            nameList.Add(1, "anik");
            nameList.Add(2, "ashik");
            nameList.Add(3, "amit");

            foreach(var Key in nameList.Keys)
            {
                Console.WriteLine(nameList[Key]);

            }
            Console.ReadKey();

        }
    }
}
