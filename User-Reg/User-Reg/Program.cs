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

            string pattern = "^[A-Z]{1,}[A-Za-z]{2,}";
            string firstName, lastName; 

            Console.WriteLine("Welcome to USER REgistration");

            Console.WriteLine("Enter your Name: ");
            firstName = Console.ReadLine();
            ValidName(firstName, pattern);

            Console.WriteLine("Enter your Name: ");
            lastName = Console.ReadLine();
            ValidLastName(lastName, pattern);


            Console.ReadLine();
        }
        public static void ValidName(string name, string pattern)
        {
            Console.WriteLine("Validating....");
            IterateLoop(name, pattern);
        }

        public static void ValidLastName(string name, string pattern)
        {
            Console.WriteLine("Validating....");
            IterateLoop(name, pattern);
        }

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
