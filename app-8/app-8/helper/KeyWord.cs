using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8
{
    internal class KeyWord
    {
        public void run() 
        {
            ICommand command = new Command1();

            if (!(command is Command2))
            {

            }

            if (command is not Command2)
            {

            }

            if ((command is ICommand) && !(command is Command2))
            {

            }


            if (command is Command1 or Command2)
            {

            }

            //************************************************

            var number = new Random().Next(1, 10);

            if (number > 2 && number < 8)
            {

            }

            if (number is > 2 and < 8)
            {

            }


            //**********************************************

            if (number <= 0)
            {
                Console.WriteLine("Less than or equal to 0");
            }
            else if (number > 0 && number <= 10)
            {
                Console.WriteLine("More than 0 but less than or equal to 10");
            }
            else
            {
                Console.WriteLine("More than 10");
            }

            // C#9.0
            switch (number)
            {
                case <= 0:
                    Console.WriteLine("Less than or equal to 0");
                    break;
                case > 0 and <= 10:
                    Console.WriteLine("More than 0 but less than or equal to 10");
                    break;
                default:
                    Console.WriteLine("More than 10");
                    break;
            }


            // C#7.0
            switch (number)
            {
                case int value when value <= 0:
                    Console.WriteLine("Less than or equal to 0");
                    break;
                case int value when value > 0 && value <= 10:
                    Console.WriteLine("More than 0 but less than or equal to 10");
                    break;
                default:
                    Console.WriteLine("More than 10");
                    break;
            }


            var message = number switch
            {
                <= 0 => "Less than or equal to 0",
                > 0 and <= 10 => "More than 0 but less than or equal to 10",
                _ => "More than 10"
            };


        }

        public static bool IsLetterOrSeparator(char c) =>
                (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '.' || c == ',';

        public static bool IsLetterOrSeparator2(char c) =>
                c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';


    }

    public interface ICommand
    {
    }

    public class Command1 : ICommand
    {
    }

    public class Command2 : ICommand
    {
    }


    public static class ModernizingACodebase
    {
        public static void PropertyPatternToReplaceIsNullorEmpty1()
        {
            string hello = null;

            // Old approach
            if (!string.IsNullOrEmpty(hello))
            {
                Console.WriteLine($"{hello} has {hello.Length} letters.");
            }

            // New approach, with a property pattern
            if (hello is { Length: > 0 })
            {
                Console.WriteLine($"{hello} has {hello.Length} letters.");
            }
        }

        public static void PropertyPatternToReplaceIsNullorEmpty2()
        {
            // For arrays
            var greetings = new string[2];
            greetings[0] = "Hello world";
            greetings = null;

            // Old approach
            if (greetings != null && !string.IsNullOrEmpty(greetings[0]))
            {
                Console.WriteLine($"{greetings[0]} has {greetings[0].Length} letters.");
            }

            // New approach
            if (greetings?[0] is { Length: > 0 } hi)
            {
                Console.WriteLine($"{hi} has {hi.Length} letters.");
            }
        }
    }

}
