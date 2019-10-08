using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_5_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();

            dt.Add(1, "Rafiq");
            dt.Add(2, "Rahim");
            foreach (var key in dt.Keys)
            {
                Console.WriteLine(dt[key]);
            }
            Console.ReadKey();
        }
    }
}
