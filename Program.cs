using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpression72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to RegulaExpression");
            Console.ReadLine();

            Console.Write("Enter First Name : ");   //taking user input of first name
            string firstname = Console.ReadLine();
            RegexValidate.FirstName(firstname);
            Console.ReadLine();

            Console.Write("Enter Last Name : ");   //taking user input of Last name
            string lastname = Console.ReadLine();
            RegexValidate.LastName(lastname);
            Console.ReadLine();

            Console.Write("Enter Email ID: ");   //taking user input of Email ID
            string Email = Console.ReadLine();
            RegexValidate.EmailValid(Email);
            Console.ReadLine();

            Console.WriteLine("Enter phone Number:");
            string Number = Console.ReadLine();
            RegexValidate.PhoneNumberValid(Number);
            Console.ReadLine();



        }
    }
}
