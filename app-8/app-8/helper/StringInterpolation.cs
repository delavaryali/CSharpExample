using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# 6
namespace app_8
{

    class Person
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Age { set; get; }
    }

    public static class StringInterpolation
    {
        public static void Run()
        {
            var person = new Person { FirstName = "User 1", LastName = "Last Name 1", Age = 50 };


            var message = string.Format("Hello!  My name is {0} {1} and I am {2} years old.",
                                          person.FirstName, person.LastName, person.Age);
            Console.Write(message);

            Console.WriteLine();

            var message2 = $"Hello!  My name is {person.FirstName} {person.LastName} and I am {person.Age} years old.";
            Console.Write(message2);


            var message3 = $"{Environment.NewLine}Test {DateTime.Now}, {3 * 2}";
            Console.Write(message3);


            var message4 = $"{Environment.NewLine}{1000000:n0} {DateTime.Now:dd-MM-yyyy}";
            Console.Write(message4);

            Console.WriteLine();

            var message5 = $"Hello! My name is {person.FirstName} {{person.FirstName}}";
            Console.Write(message5);

            Console.WriteLine();

            Console.Write($"{(person.Age > 50 ? "old" : "young")}");

            Console.WriteLine();

            const string constStrFirst = "FirstStr";
            const string summaryConstStr = $"SecondStr {constStrFirst}";

            Console.Write(summaryConstStr);
        }

        //C# 11
        public static void NewLinesStringInterpolations()
        {
            var month = 8;
            var season = $"The season is {month switch
            {
                >= 1 and <= 3 => "spring",
                >= 4 and <= 6 => "summer",
                >= 7 and <= 9 => "autumn",
                10 or 11 or 12 => "winter",
                _ => "Wrong month number",
            }}.";
            Console.WriteLine(season);

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            var message = $"The reversed even values of {nameof(numbers)} are {string.Join(", ",
                numbers.Where(n => n % 2 == 0).Reverse())}.";
            Console.WriteLine(message);
        }

    }



}
