using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8
{
    class TupleSample
    {
        public static (string, string, int) GetNewTuple()
        {
            string name = "Iman";
            string family = "Madaeny";
            int age = 30;

            return (name, family, age);
        }

        public static (string name, string family, int age) GetPerson()
        {
            string name = "Iman";
            string family = "Madaeny";
            int age = 30;

            return (name, family, age);
        }
    }
}
