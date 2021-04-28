using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User_Reg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to USER-REGISTARTION");

            string pattern = "^[A-Z]{1,}[A-Za-z]{2,}"; //for first and last name 
            string Epattern = "^[abc]*[@a-zA-Z].[com]*"; //for Email validation Pattern
            string phPattern = "^[91][0-9]{10}"; //for Phone number
            string passPattern = "^[A-Z]{1,}[A-Za-z0-9]{7,}";

            //initializing variables
            string firstName, lastName,eMail,phNumber,password;     

            Console.WriteLine("Welcome to USER REgistration");
            //for First name
            Console.WriteLine("Enter your Name: ");
            firstName = Console.ReadLine();
            ValidName(firstName, pattern);

            //For last name 
            Console.WriteLine("Enter your Name: ");
            lastName = Console.ReadLine();
            ValidLastName(lastName, pattern);

            //for Email 
            Console.WriteLine("Enter your Name: ");
            eMail = Console.ReadLine();
            ValidEmail(eMail, Epattern);

            //for Phone number
            Console.WriteLine("Enter your Name: ");
            phNumber = Console.ReadLine();
            PhnoneNumber(phNumber, phPattern);

            //for password
            Console.WriteLine("Enter your Name: ");
            password = Console.ReadLine();
            Password(password, passPattern);

            Console.ReadLine();
        }
        /// <summary>
        /// Valids the name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="pattern">The pattern.</param>
       public static void ValidName(string name, string pattern)
        {
            Console.WriteLine("Validating....");
            IterateLoop(name, pattern);
        }

        /// <summary>
        /// Valids the last name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="pattern">The pattern.</param>
        /// <returns></returns>
        public static void ValidLastName(string name, string pattern)
        {
            Console.WriteLine("Validating....");
            IterateLoop(name, pattern);
        }

        /// <summary>
        /// Valids the email.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="pattern">The pattern.</param>
        public static void ValidEmail(string name, string pattern)
        {
            Console.WriteLine("Validating....");
            IterateLoop(name, pattern);
        }

        /// <summary>
        /// Phnones the number.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="pattern">The pattern.</param>
        public static void PhnoneNumber(string name, string pattern)
        {
            Console.WriteLine("Validating....");
            IterateLoop(name, pattern);
        }

        /// <summary>
        /// Passwords the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="pattern">The pattern.</param>
        public static void Password(string name, string pattern)
        {
            Console.WriteLine("Validating....");
            IterateLoop(name, pattern);
        }



        /// <summary>
        /// Iterates the loop.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="pattern">The pattern.</param>
        public static void IterateLoop(string name, string pattern)
        {
            Regex regex = new Regex(pattern);
                bool result = regex.IsMatch(name);
                if (result)
                {
                    Console.WriteLine("Valid Name---->" + name);
                }
                else
                {
                    Console.WriteLine("InValid Name---->" + name);
                }
            
        }
    }
}
