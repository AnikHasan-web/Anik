﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, middleName, lastName;
            firstName= Console.ReadLine();
            middleName = Console.ReadLine();
            lastName = Console.ReadLine();
            string FullName = GetFullName(firstName,middleName,lastName);

	    Console.WriteLine("Fullname:"+ Fullname);
            Console.ReadKey();

        }

        static string GetFullName(string fName,string mName,string lName)
        {
            string FullName = fName + mName + lName;
            return FullName;
        }
    }
}
