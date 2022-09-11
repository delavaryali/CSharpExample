using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# 7
namespace app_7
{
    public static class TupleReturnTypesAndDeconstruction
    {
        public static void Run()
        {
            var location = new Tuple<string, string>("Lake Charles", "LA");

            // Print out the address
            var address = $"{location.Item1}, {location.Item2}";

            Console.WriteLine(address);

            var data = GetHumanData();
            Console.WriteLine("What is this value {0} or this {1}", data.Item1, data.Item3);






            (int Age, string FirstName, string LastName) = GetHumanData();
            Console.WriteLine(Age);
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);


            (int x1, string s1) = (3, "one");
            Console.WriteLine($"{x1} {s1}");

            (int result, int reminder) = Divide(11, 3);
            Console.WriteLine($"{result} {reminder}");





            var tuple3 = (Name: "Matthias", Age: 6);
            Console.WriteLine($"{tuple3.Name} {tuple3.Age}");



            var circle = CalculateAreaOfCircle(2);
            Console.WriteLine($"A circle of radius, {circle.radius}," +
             $" has an area of {circle.area:N2}.");


            //Deconstructing Tuples
            var p1 = new Person3("Katharina", "Nagel");
            (string first, string last) = p1;
            Console.WriteLine($"{first} {last}");

            //Deconstructing Tuples
            var r1 = new Rectangle(100, 200);
            (int height, int width) = r1;
            Console.WriteLine($"height: {height}, width: {width}");







            string name = "User 1";
            int age = 20;
            var personTuple = (name, age);
            Console.WriteLine(personTuple.name); // User 1
            Console.WriteLine(personTuple.age); // 20
        }

        static Tuple<int, string, string> GetHumanData()
        {
            return Tuple.Create(10, "Marcus", "Miller");
        }

        static (int, int) Divide(int x, int y)
        {
            int result = x / y;
            int reminder = x % y;

            return (result, reminder);
        }

        static (int radius, double area) CalculateAreaOfCircle(int radius)
        {
            return (radius, Math.PI * Math.Pow(radius, 2));
        }
    }

    class Person3
    {
        private readonly string _firstName;
        private readonly string _lastName;

        public Person3(string firstname, string lastname)
        {
            _firstName = firstname;
            _lastName = lastname;
        }

        public override String ToString() => $"{_firstName} {_lastName}";

        public void Deconstruct(out string firstname, out string lastname)
        {
            firstname = _firstName;
            lastname = _lastName;
        }
    }



    public class Rectangle
    {
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Width { get; }
        public int Height { get; }
    }

    public static class RectangleExtensions
    {
        public static void Deconstruct(this Rectangle rectangle, out int height, out int width)
        {
            height = rectangle.Height;
            width = rectangle.Width;
        }
    }
}
