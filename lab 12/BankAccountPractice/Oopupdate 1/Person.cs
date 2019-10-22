using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oopBasic
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        

       
        public string GetFullName()
        {
            if (MiddleName == null)
            {
                return FirstName + " " + LastName;
            }
            else
            {
                return FirstName + " " + MiddleName + " " + LastName;
            }
           
           
        }
        

        public string GetReverseName()//method
        {
            string fullName = GetFullName();
            char[] charArray = fullName.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
