using System;
using System.Collections;
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
            ArrayList nameList = new ArrayList();
            nameList.Add("anik");
            nameList.Add("hasan");
            nameList.Add("ashik");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);

            }

            Console.WriteLine("---------------------------------------------");
            ArrayList numberList = new ArrayList();
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            foreach (var number in numberList)
            {
                Console.WriteLine(number);

            }

            Console.WriteLine("---------------------------------------------");

            Stack numberListStack = new Stack();
            numberListStack.Push(1);
            numberListStack.Push(2);
            numberListStack.Push(3);
            var num = numberListStack.Pop();
            foreach (var number in numberListStack)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Deleted item:");
            Console.WriteLine(num);
            Console.WriteLine("---------------------------------------------");

            Queue numberListQueue = new Queue();
            numberListQueue.Enqueue(1);
            numberListQueue.Enqueue(2);
            numberListQueue.Enqueue(3);
            var num1 = numberListQueue.Dequeue();
            foreach (var number in numberListQueue)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Deleted item:");
            Console.WriteLine(num);
            Console.ReadKey();
            
        }
    }
}
