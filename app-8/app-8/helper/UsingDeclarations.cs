using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using static System.Console;
using static System.Math;
using static app_8.Gender2;
using static app_8.MyStaticClass;


namespace app_8
{
    enum Gender2
    {
        Male,
        Female
    }

    internal class UsingDeclarations
    {

        static void run()
        {
            Write(" *** Cal Area *** ");
            int r = int.Parse(ReadLine());
            var result = Pow(r, 2) * PI;
            Write($"Area  is : {result}");
            ReadKey();

            var gender = Male;//تخصيص نوع داده شمارشي
            WriteLine($"Employee Gender is : {Male}");//استفاده مستقيم از نوع داده شمارشي


            //فراخواني تابع استاتيک
            Print1("Print 1");//روش اول
            MyStaticClass.Print1("Prtint 1");//روش دوم
                                             //فراخواني متد الحاقي استاتيک
            MyStaticClass.Print2("Print 2");
            "print 2".Print2();
        }

        static void UsingOld()
        {
            using (var file = new FileStream("input.txt", FileMode.Open))
            using (var reader = new StreamReader(file))
            {
                var s = reader.ReadToEnd();


                // Do something with data
            }
        }


        static void UsingNew(string[] args)
        {
            using Stream file = new FileStream("input.txt", FileMode.Open);
            using StreamReader reader = new StreamReader(file);

            var s = reader.ReadToEnd();

            // Do something with data
        }

    
    }

    public static class MyStaticClass
    {
        public static void Print1(string parameter)
        {
            WriteLine(parameter);
        }
        public static void Print2(this string parameter)
        {
            WriteLine(parameter);
        }

    }
}
