using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_7
{
    internal class UsingDeclarations
    {
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
}
