using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationOneToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("23", "12S", "Jigatola", 45, "dhaka");
            Person person = new Person("Md", "Anik", "Hasan");
            string fullName = person.GetFullName();
            person.PersonAddress = address;
            //Address personAddress = person.PersonAddress;
            string houseNo = person.PersonAddress.HouseNo;
            string roadNo = person.PersonAddress.RoadNo;
            string ward = person.PersonAddress.Ward;
            int postalCode = person.PersonAddress.PostCode;
            string district = person.PersonAddress.District;

            Console.WriteLine("Person Information"+"\n\n"+"Name: " + fullName+"\n"+"Address:     "+"House No: "+houseNo+","
                +"Road No: "+roadNo+","+"Ward: "+ward+","+"postalCode Coode: "+postalCode+","+"District: "+district);
            Console.ReadKey();
        }
    }
}
