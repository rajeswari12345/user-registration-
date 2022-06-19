using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace RegexpatternProblems
{
    internal class RegexPattern
    {
        string pattern = "^[A-Za-z]{3,}$";

        public void validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("validating the first name");
            ValidatingFirstname();

        }

        public void validatingFirstName()
        {
            Regex Regex = new Regex(pattern);
            Console.WriteLine("Enter the first name:");
            string input = Console.ReadLine();
            bool res = Regex.IsMatch(input);
            if (res)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");

            }
        }

        string pattern = "^[A-Za-z]{3,}$";
        public void validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("validating the last name");
            ValidatingLastname();

        }

        public void validatingLastName()
        {
            Regex Regex = new Regex(pattern);
            Console.WriteLine("Enter the last name:");
            string input = Console.ReadLine();
            bool res = Regex.IsMatch(input);
            if (res)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");

            }

            string pattern = " ^[a - zA - Z0 - 9 + _.-] +@[a-zA - Z0 - 9.-]+$";

            public void validating()
            {
                Regex regex = new Regex(pattern);
                Console.WriteLine("validating the  Email");
                ValidatingFirstname();

            }

            public void validatingEmail()
            {
                Regex Regex = new Regex(pattern);
                Console.WriteLine("Enter the email:");
                string input = Console.ReadLine();
                bool res = Regex.IsMatch(input);
                if (res)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("Invalid");

                }
            }
        }
    }
}
