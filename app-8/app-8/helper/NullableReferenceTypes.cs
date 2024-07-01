using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8
{
    internal class NullableReferenceTypes
    {

    }

    public class Person6
    {
  


        public string Name { get; set; }
        public Person6(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }




        private string _innerValue = string.Empty;

        [AllowNull]
        public string MyValue
        {
            get
            {
                return _innerValue;
            }
            set
            {
                _innerValue = value ?? string.Empty;
            }
        }



        public static bool IsNullOrEmpty([NotNullWhen(false)] string? value)
        {
            return true;
        }

        public static bool TryParse(string? input, [NotNullWhen(true)] out Version? version)
        {
            version = default;
            return true;
        }


    }

    public class MyQueue<T>
    {
        // 'result' could be null if we couldn't Dequeue it.
        public bool TryDequeue([MaybeNullWhen(false)] out T result)
        {
            result = default;
            return true;
        }
    }
}
