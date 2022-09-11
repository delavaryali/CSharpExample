using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_7
{
    public static class LocalFunctions
    {
        public static void Run()
        {
            int Add(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Add(3, 4));
        }
    }


    public class PersonWithPrivateMethod
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            string ageSuffix = GenerateAgeSuffix(Age);
            return $"{Name} is {Age} year{ageSuffix} old";
        }

        private string GenerateAgeSuffix(int age)
        {
            return age > 1 ? "s" : "";
        }
    }

    public class PersonWithLocalFuncDelegate
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            Func<int, string> generateAgeSuffix = age => age > 1 ? "s" : "";
            return $"{Name} is {Age} year{generateAgeSuffix(Age)} old";
        }
    }

    public class PersonWithLocalFunction
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} is {Age} year{GenerateAgeSuffix(Age)} old";
            // Define a local function:
            string GenerateAgeSuffix(int age)
            {
                return age > 1 ? "s" : "";
            }
        }
    }


    public class PersonWithLocalFunctionEnclosing
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} is {Age} year{GenerateAgeSuffix()} old";
            // Define a local function:
            string GenerateAgeSuffix()
            {
                return Age > 1 ? "s" : "";
            }
        }
    }

    public class PersonWithLocalFunctionExpressionBodied
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} is {Age} year{GenerateAgeSuffix(Age)} old";
            // Define a local function:
            string GenerateAgeSuffix(int age) => age > 1 ? "s" : "";
        }
    }



}
