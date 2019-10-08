
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double i,sumOfSquareNumber = 0, squareOfSumNumbers = 0,diff ;

            for (i = 1; i <= 100; i++)
            {
              
                    sumOfSquareNumber  += Math.Pow (i , 2);
                    squareOfSumNumbers += i;
                
            }
            squareOfSumNumbers = Math.Pow(squareOfSumNumbers ,2);
            Console.WriteLine("The sum of the squares of the first one hundred natural numbers is" + sumOfSquareNumber);
            
           
            Console.WriteLine("The square of the sum of the first one hundred natural numbers is" + squareOfSumNumbers );
            
            diff = squareOfSumNumbers - sumOfSquareNumber;
            
            Console.WriteLine("difference between them" + diff);
            Console.ReadKey();
        }
    }
}