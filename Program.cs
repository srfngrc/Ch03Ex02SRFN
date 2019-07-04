using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Ch03Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            ConsoleKeyInfo input;

            Console.BackgroundColor= ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Blue;

            //Console.Beep();
            Console.WriteLine("Press a key, together with Alt, Ctrl, or Shift.");
            Console.WriteLine("Press Esc to exit.");
            input = Console.ReadKey(true);
            Console.WriteLine("soooooo this is: " + input);

            Emailer emailerClass = new Emailer();
            emailerClass.SendEmail("","","");

            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine("Welcome {0, 26}!", userName);
            Console.WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumber,
            secondNumber, firstNumber + secondNumber);
            Console.Beep();
            Console.WriteLine("The result of subtracting {0} from {1} is {2}.",
            secondNumber, firstNumber, firstNumber - secondNumber);
            Console.Beep();
            Console.WriteLine("The product of {0} and {1} is {2}.", firstNumber,
            secondNumber, firstNumber * secondNumber);
            Console.Beep();
            Console.WriteLine("The result of dividing {0} by {1} is {2}.",
            firstNumber, secondNumber, firstNumber / secondNumber);
            Console.Beep();
            Console.WriteLine("The remainder after dividing {0} by {1} is {2}.",
            firstNumber, secondNumber, firstNumber % secondNumber);
            Console.ReadKey();
        }
    }
}

namespace Utilities
{
    class Emailer
    {
        public void SendEmail(string to, string from, string message)
        {
            //send some emails
        }
    }   
}