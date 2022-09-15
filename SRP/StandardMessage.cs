using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class StandardMessage
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my application");
        }

        public static void Guide(string inputField)
        {
            Console.WriteLine($"Enter your {inputField}:");
        }

        public static void ShowErrorMessage(string inputField)
        {
            Console.WriteLine($"Invalid {inputField}");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void ShowResult(Person person)
        {
            Console.WriteLine($"Your name is : {person.FirstName.Substring(0, 1)} {person.LastName}");

        }
    }
}
