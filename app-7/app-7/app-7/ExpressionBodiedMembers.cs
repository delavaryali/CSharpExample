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
