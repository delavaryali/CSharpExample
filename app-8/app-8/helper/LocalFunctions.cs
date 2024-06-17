using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

//**********************************************************
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

public class LocalFunctionsTest
{
    public void PassAnonFunctionToMethod()
    {
        var p = new SimplePerson
        {
            Name = "Name1",
            Age = 42
        };
        OutputSimplePerson(p, GenerateAgeSuffix);
        string GenerateAgeSuffix(int age) => age > 1 ? "s" : "";
    }

    private void OutputSimplePerson(SimplePerson person, Func<int, string> suffixFunction)
    {
        Console.WriteLine(
        $"{person.Name} is {person.Age} year{suffixFunction(person.Age)} old");
    }
}

public class SimplePerson
{
    public int Age { get; set; }
    public string Name { get; set; }
}





class StaticLocalFunctions
{
    static void Main()
    {
        ClassicCapture(); // Implicitly captured variables in the method scope
        NonCapturing(); // Now we can explicitly prevent that
    }

    internal static int ClassicCapture()
    {
        int y;
        LocalFunction();
        return y;

        void LocalFunction() => y = 19;
    }

    internal static int NonCapturing()
    {
        int y = 5, x = 7;
        return Add(x, y);

        static int Add(int left, int right) => left + right;
    }
}


