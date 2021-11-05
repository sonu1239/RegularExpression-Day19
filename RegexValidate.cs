﻿using System;
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

        //this method for validation of phone number
        public static void PhoneNumberValid(string number)

        {

            string phoneNum = "^[6-9]{1}[0-9]{9}$";
            Regex regex = new Regex(phoneNum);

            if (regex.IsMatch(number))
            {

                Console.WriteLine("phone number is valid");


            }
            else
            {
                Console.WriteLine("phone number is invalid, please Enter is Valid \n refer and try again:6523456789");

            }

        }



    }
}