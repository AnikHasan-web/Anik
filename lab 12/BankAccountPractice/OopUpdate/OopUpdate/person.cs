using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopUpdate
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string personalId;

        
        public Person(string firstName, string middleName, string lastName)
            : this(firstName, lastName)
        {
            this.MiddleName = middleName;
        }

        public Person(string firstName, string lastName)
            : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person()
        {

        }

        public string GetFullName()
        {
            string fullName = FirstName + " " + MiddleName + " " + LastName;
            return fullName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            char[] charArray = fullName.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
