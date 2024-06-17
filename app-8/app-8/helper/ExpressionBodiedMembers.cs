using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# 6

public static class ExpressionBodiedMembers
{

}

public class Person4
{
    public string Name { get; }
    public int Age { get; }

    public Person4(string name, int age) => (Name, Age) = (name, age);
}

public class Person2
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }

    public Person2(string firstName, string lastName) => (FirstName, LastName) = (firstName, lastName);

    public string FullName2 => FirstName + " " + LastName;

    public override string ToString() => FirstName;

    public int DoubleTheValue(int someValue) => someValue * 2;


    //destructor
    ~Person2() => Console.WriteLine("destructor");



    private int _x;
    public int X
    {
        get
        {
            return _x;
        }
        set
        {
            _x = value;
        }
    }

    private int _y;
    public int y
    {
        get => _y;
        set => _y = value;
    }


    //public override string ToString()
    //{
    //    if (MiddleName != null)
    //    {
    //        return FirstName + " " + MiddleName + " " + LastName;
    //    }
    //    else
    //    {
    //        return FirstName + " " + LastName;
    //    }
    //}


    //public override string ToString() =>
    //            (MiddleName != null)
    //            ? FirstName + " " + MiddleName + " " + LastName
    //            : FirstName + " " + LastName;

}

public class Person5
{
    private readonly (string name, int age) _tuple;

    public string Name => _tuple.name;
    public int Age => _tuple.age;

    public Person5(string name, int age) => _tuple = (name, age);

}
