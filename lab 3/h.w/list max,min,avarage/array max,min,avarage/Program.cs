using System;
using System.Collections;
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
            List<int> numberList = new List<int>();
            Console.WriteLine("Enter the size of the list: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the list of size {0} ", size);
            for (int i = 0; i < size; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                numberList.Add(number);
            }

            int avarage = GetAvarage(numberList);
            Console.WriteLine("Avarage number: " + avarage);
            int maximumNumber = GetMaximumNum(numberList);
            Console.WriteLine("Maximum Number: " + maximumNumber);
            int minimumNumber = GetMinimumNum(numberList);
            Console.WriteLine("Minimum Number: " + minimumNumber);
            Console.ReadKey();
        }
        static int GetAvarage(List<int> array)
        {
            int sum = 0;
            foreach (int data in array)
            {
                sum = sum + data;
            }
            int avarage = sum / array.Length;
            return avarage;
        }
        static int GetMaxNumber(List<int> numberArray)
        {
            int max = numberArray[0];
            foreach (int number in numberArray)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }
        static int GetMinNumber(List<int> numberArray)
        {
            int min = numberArray[0];
            foreach (int number in numberArray)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}
