using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
using static app_7.Gender;

//C# 6
namespace app_7
{
    public static class StaticUsingStatements
    {
        public static void Run()
        {

            Write(" *** Cal Area *** ");
            int r = int.Parse(ReadLine());
            var result = Pow(r, 2) * PI;
            Write($"Area  is : {result}");
            ReadKey();

            var gender = Male;//تخصیص نوع داده شمارشی
            WriteLine($"Employee Gender is : {Male}");//استفاده مستقیم از نوع داده شمارشی
        }

       
    }

    public enum Gender
    {
        Male,
        Female
    }
}
