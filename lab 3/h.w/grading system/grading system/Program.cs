using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grading_system
{
    class Program
    {
        static void Main(string[] args)
        {
            char decision;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Enter First Name: ");
                string first = Console.ReadLine();

                Console.WriteLine("Enter Last Name: ");
                string last = Console.ReadLine();

                Console.WriteLine("Enter Subject: ");
                string subject = Console.ReadLine();

                Console.WriteLine("Enter Mark: ");
                int mark = Convert.ToInt32(Console.ReadLine());

                string full = GetFullName(first, last);
                string grade = GetGrade(mark);

                Console.WriteLine(" ");

                if (mark <= 100 && mark >= 40)
                {
                    Console.WriteLine("Hello " + full + " Congratulations! You have passed in " + subject + " and your grade is " + grade);
                }
                else
                {
                    Console.WriteLine("Sorry you have failed. Please try again!");
                }
                


                Console.WriteLine(" ");

                Console.WriteLine("Do you want to continue(y/n)?");

                decision = Convert.ToChar(Console.ReadLine());

            } while (decision=='y' || decision== 'Y');

            Console.ReadKey();
        }


        static string GetFullName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }

        static string GetGrade(int mark)
        {
            

            if (mark <= 100 && mark >= 80)
            {
                return  "A+";
            }
            else if (mark <= 79 && mark >= 75)
            {
                return   "A";

            }
            else if (mark <= 74 && mark >= 70)
            {
                return  "A-";

            }
            else if (mark <= 69 && mark >= 65)
            {
                return "B+";

            }
            else if (mark <= 64 && mark >= 60)
            {
                return "B";

            }
            else if (mark <= 59 && mark >= 55)
            {
                return "B-";

            }
            else if (mark <= 54 && mark >= 50)
            {
                return "C+";

            }
            else if (mark <= 49 && mark >= 45)
            {
                return "C";

            }
            else if (mark <= 44 && mark >= 40)
            {
                return "D";

            }
            else 
            {
                return "F";
            }

            
        }
    }
}
