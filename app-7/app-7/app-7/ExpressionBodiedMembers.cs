using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# 6
namespace app_7
{
    public static  class ExpressionBodiedMembers
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

        public string FullName2 => FirstName + " " + LastName;

        public override string ToString() => FirstName;

        public int DoubleTheValue(int someValue) => someValue * 2;


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
}
