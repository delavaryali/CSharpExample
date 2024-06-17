using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class OutVariables
{
    public static void Run()
    {
        int numericResult;
        if (int.TryParse("52", out numericResult))
            Console.Write(numericResult);
        else
            Console.Write("Could not parse input");



        if (int.TryParse("52", out int result))
            Console.Write(result);
        else
            Console.Write("Could not parse input");

        //**************************************************
        string firstName;
        string lastName;

        CreateName(out firstName, out lastName);
        Console.WriteLine($"Hello {firstName} {lastName}");

        //inline
        CreateName(out string firstName2, out string lastName2);
        Console.WriteLine($"Hello {firstName2} {lastName2}");


        //*************************************************
        var intString = "123";
        if (int.TryParse(intString, out _))
        {
            // it's integer
        }
    }

    private static void CreateName(out string firstName, out string lastName)
    {
        firstName = "Kevin";
        lastName = "Griffin";
    }
}

