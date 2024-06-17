using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# 7
namespace app_8
{
    public static class PatternMatchingAndSwitchExpressions
    {
        public static void Run()
        {
            object[] data = { null, 42, new User("User 1"), new User("User 2") };
            foreach (var item in data)
            {
                if (item is null) Console.WriteLine("it's a const pattern");
                if (item is 42) Console.WriteLine("it's 42");
            }



            object[] data2 = { null, 42, new User("User 1"), new User("User 2") };
            foreach (var item in data2)
            {
                if (item is int i) Console.WriteLine($"it's a type pattern with an int and the value {i}");
                if (item is User p) Console.WriteLine($"it's a person: {p.Name}");
                if (item is User p2 && p2.Name.StartsWith("U"))
                {
                    Console.WriteLine($"it's a person starting with U {p2.Name}");
                }
            }



            object[] data3 = { null, 42, new User("User 1"), new User("User 2") };
            foreach (var item in data3)
            {
                if (item is var x) Console.WriteLine($"it's a var pattern with the type {x?.GetType()?.Name}");
            }




            object obj1 = "Hello, World!";
            var str1 = obj1 as string;
            if (str1 != null)
            {
                Console.WriteLine(str1);
            }

            object obj2 = "Hello, World!";
            if (obj2 is string str2)
            {
                Console.WriteLine(str2);
            }







            string ageBlock;
            var age = 40;
            switch (age)
            {
                case 50:
                    ageBlock = "the big five-oh";
                    break;
                case var testAge when (new List<int> { 80, 81, 82, 83, 84, 85, 86, 87, 88, 89 }).Contains(testAge):
                    ageBlock = "octogenarian";
                    break;
                case var testAge when ((testAge >= 90) && (testAge <= 99)):
                    ageBlock = "nonagenarian";
                    break;
                case var testAge when (testAge >= 100):
                    ageBlock = "centenarian";
                    break;
                default:
                    ageBlock = "just old";
                    break;
            }
        }

        public static void SwitchPattern(object o)
        {
            switch (o)
            {
                case null:
                    Console.WriteLine("it's a constant pattern");
                    break;
                case int i:
                    Console.WriteLine("it's an int");
                    break;
                case User p when p.Name.StartsWith("U"):
                    Console.WriteLine($"a U person {p.Name}");
                    break;
                case User p:
                    Console.WriteLine($"any other person {p.Name}");
                    break;
                case var x:
                    Console.WriteLine($"it's a var pattern with the type {x?.GetType().Name} ");
                    break;
                default:
                    break;
            }
        }
    }

    public class User
    {
        public User(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
