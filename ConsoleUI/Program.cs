using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            SayAuthor();

            string firstName = GetUserName("What is your first name: ");
            string lastName = GetUserName("What is your last name: ");

            WelcomeUser(firstName, lastName);

            Console.ReadLine();
        }

        private static void SayAuthor()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Written By: Brice Donald");
            Console.WriteLine("In his way to C# mastering");
            Console.WriteLine("*****************************");
        }


        private static void WelcomeUser(string firstName, string lastName)
        {
            Console.WriteLine($"Hello {firstName} {lastName}");
        }

        private static string GetUserName(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            if (output.Length > 1)
            {
                return output;
            }
            else
            {
                return "UNKNOWN";
            }
        }


    }
}
