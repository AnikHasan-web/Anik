using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_max_min_avarage
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
            int maximumNumber = GetMaximumNum(numberList);
            Console.WriteLine("Maximum Number: " + maximumNumber);
            int minimumNumber = GetMinimumNum(numberList);
            Console.WriteLine("Minimum Number: " + minimumNumber);
            Console.ReadKey();
        }
        static int GetAvarage(int[] array)
        {
            int sum = 0;
            foreach (int data in array)
            {
                sum = sum + data;
            }
            int avarage = sum / array.Length;
            return avarage;
        }
        static int GetMaximumNum(int[] myNumberArray)
        {
            int max = myNumberArray[0];
            foreach (int number in myNumberArray)
            {
                if (number >= max)
                {
                    max = number;
                }
            }
            return max;
        }
        static int GetMinimumNum(int[] myNumberArray)
        {
            int min = myNumberArray[0];
            foreach (int number in myNumberArray)
            {
                if (number <= min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}
