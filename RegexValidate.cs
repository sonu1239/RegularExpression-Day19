using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpression72
{
    class RegexValidate
    {



        //We are using this method to match pattern of first name and
        public static void FirstName(string name)
        {
            string firstname = "^[A-Z]{1}[a-zA-Z]{2}$";      //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(firstname);

            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid name");
            }
            else
            {
                Console.WriteLine(name + " is invalid.\n Please Enter First name start with capital letter and maximum 3 characters");
            }
        }
        //We are using this method to match pattern of last name
        public static void LastName(string name)
        {
            string lastname = "^[A-Z]{1}[a-zA-Z]{2}$";      //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(lastname);

            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid name");
            }
            else
            {
                Console.WriteLine(name + " is invalid.\n Please Enter Last name start with capital letter and maximum 3 characters");
            }
        }
        //This method for validation of email id
        public static void EmailValid(string mail)
        {
            string emailid = "^[a-z]{3}[.][a-z0-9]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";
            Regex regex = new Regex(emailid);

            if (regex.IsMatch(mail))
            {
                Console.WriteLine("Email Id is valid");
            }
            else
            {
                Console.WriteLine("Email Is Invalid,Please Enter Valid email Id\n Refer and try again: abc.xyz@bl.co.in");
            }

        }
        //This method will check whether phone no is valid or not
        public static void MobileNumValid(string number)
        {
            //Regular expression of mobile number
            string Mobnumber = "^[0-9]{1,2}[ ]{1}[0-9]{10}$";
            Regex regex = new Regex(Mobnumber);

            if (regex.IsMatch(number))
            {
                Console.WriteLine("Mobile Number is valid");
            }
            else
            {
                Console.WriteLine("Mobile number is Invalid,Please Enter Valid MObile Number format.");
            }

        }
        public static void PassWord(string pass)
        {
            string pwd = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$";
            Regex regex = new Regex(pwd);                                           //creating a regex named obj with regular pwd.
            if (regex.IsMatch(pass))
            {
                Console.WriteLine(pass + " is valid.");
            }
            else
                Console.WriteLine(pass + " is invalid. Password must contain atleast one capital letter & one number");
        }

    }
}


