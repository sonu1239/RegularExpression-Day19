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
            Console.WriteLine("Welcome to Regular Expression Program");
            Console.WriteLine();

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

            Console.WriteLine("Enter mobile number in this format : 00 0000000000"); //taking user input of Mobile No
            string MobileNo = Console.ReadLine();
            RegexValidate.MobileNumValid(MobileNo);
            Console.ReadLine();

            Console.Write("Enter password: ");   //taking user input of password1
            string password1 = Console.ReadLine();
            RegexValidate.PassWord(password1);
            Console.ReadLine();

        }
    }
}
