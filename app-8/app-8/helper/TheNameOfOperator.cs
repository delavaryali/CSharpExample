using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//C# 6
namespace app_8
{
    public static class TheNameOfOperator
    {
        public static void DoWork(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
        }

        public static void DoWork2(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
        }


        //C# 11
        //امکان دسترسي به نام پارامتر متد، در حالت اعمال به متد
        //[MyAttr(nameof(parameter))]
        //void Method(string parameter)
        //{
        //}


        //امکان دسترسي به نام نوع پارامتر جنريک متد، در حالت اعمال به متد
        //[MyAttr(nameof(T))]
        //void Method<T>()
        //{
        //}

        //امکان دسترسي به نام پارامتر متد، در حالت اعمال به پارامتر
        //void Method([MyAttr(nameof(parameter))] int parameter)
        //{
        //}


        //يکي از کاربردهاي آن، بهبود تعاريف متاديتاي nullable reference types و عدم نياز به کار با رشته‌ها به صورت مستقيم است
        //[return: NotNullIfNotNull(nameof(path))]
        //public static string? GetUrl(string? path)
        //=> !string.IsNullOrEmpty(path) ? $"https://localhost/api/{path}" : null;


        //خطا
        //nameof(f()); // where f is a method - you could use nameof(f) instead
        //nameof(c._Age); // where c is a different class and _Age is private. Nameof can't break accessor rules.
        //nameof(List<>); // List<> isn't valid C# anyway, so this won't work
        //nameof(default(List<int>)); // default returns an instance, not a member
        //nameof(int); // int is a keyword, not a member- you could do nameof(Int32)
        //nameof(x[2]); // returns an instance using an indexer, so not a member
        //nameof("hello"); // a string isn't a member
        //nameof(1 + 2); // an int isn't a member


        //C# 12
        public class NameofClass
        {
            public string SomeProperty { get; set; }

            // Now legal with C# 12
            // would show "Length" on the console
            public const string NameOfSomePropertyLength = nameof(SomeProperty.Length);

            public static int StaticField;
            public const string NameOfStaticFieldMinValue = nameof(StaticField.MinValue);

            [Description($"String {nameof(SomeProperty.Length)}")]
            public int StringLength(string s)
            {
                return s.Length;
            }
        }

    }
}
