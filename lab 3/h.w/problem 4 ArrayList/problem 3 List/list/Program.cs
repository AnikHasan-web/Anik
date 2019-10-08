using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listName = new List<string>();
            listName.Add("BITM");
            listName.Add("BASIS");
            listName.Add("SEIP");
            listName.Add("DOT NET");
            foreach( string data in listName)
            {
                Console.WriteLine(data);
            }
            Console.ReadKey();
        }
    }
}
