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
            bool hola = 6 < 10;
            double firstNumber, secondNumber;
            string userName;
            ConsoleKeyInfo input;
            string supercalifragilisticexpialidocious;

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

            exercises.ExercisesSerafin();
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

//Excercises pages 45 and 46 Book
//Excercise 3.1
namespace super
{
    namespace smashing
    {
        public class great{}
        // great name defined
    }
}
namespace fabulous
{
    class test
        {
                // code in fabulous namespace
                super.smashing.great sendstorm3453;
        }
    
}

namespace exercises
{
    

//Excercise 3.2
//myVariableIsGood:     LEGAL
//99Flake               ILLEGAL, starts w/ a number
//_floor                LEGAL
//time2GetJiggyWidIt    LEGAL   
//wrox.com              ILLEGAL, contains a full stop

//Excercise 3.3
//string supercalifragilisticexpialidocious;    LEGAL

//Excercise 3.4
//resultVar += (var1 * var2) + (var3 % (var4 / var5));
//resultVar += (var1 * var2) + ((var3 % var4) / var5));

 class ExercisesSerafin
    {
            double double1;
            double double2;
            double double3;
            double double4;

            //Excercise 3.5
            Console.WriteLine("Please insert value 1:");
            double1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Value 1 is: " + double1);
            Console.ReadLine();
    }


}
