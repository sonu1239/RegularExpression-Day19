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

        }
    }
}
