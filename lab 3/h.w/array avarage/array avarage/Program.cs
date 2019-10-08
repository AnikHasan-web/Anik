using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_avarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numberList = new int[size];
            Console.WriteLine("Enter integer numbers size of {0}.", size);
            for (int i = 0; i < size; i++)
            {
                numberList[i] = Convert.ToInt32(Console.ReadLine());
            }
            int avarage = GetAvarage(numberList);
            Console.WriteLine("Avarage number: " + avarage);
            Console.ReadKey(); 
        }
        static int GetAvarage(int [] array)
        {
	        int sum=0;
            foreach(int data in array)
	        {
		        sum=sum+data;
	        }
            int avarage=sum/array.Length;
            return avarage;
       }
        
    }
}
