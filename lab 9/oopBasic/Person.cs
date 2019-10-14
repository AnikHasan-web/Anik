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
        public string firstName;
        public string middleName;
        public string lastName;
        public string id;
        public string personalId;

        public Person(string firstName, string middleName, string lastName):this(firstName,lastName)
        {
            this.middleName = middleName;
        }
        public Person(string firstName, string lastName) : this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person()
        {
            id = "000000";
        }
        public string GetFullName()
        {
            if (middleName == null)
            {
                return firstName + " " + lastName;
            }
            else
            {
                return firstName + " " + middleName + " " + lastName;
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
