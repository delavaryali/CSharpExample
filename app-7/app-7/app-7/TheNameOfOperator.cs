using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# 6
namespace app_7
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

     
    }
}
