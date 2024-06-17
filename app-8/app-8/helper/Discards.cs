using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8
{
    internal class Discards
    {
        public void run()
        {
            Boolean parsedValue;

            if (bool.TryParse("TRUE", out parsedValue)) { /* Do your stuff */ }

            if (bool.TryParse("TRUE", out bool _)) { /* Do your stuff */ }

            //************************************

            var (arg1, _, _) = (1, 2, 3);

            //**************************************

            object input = "";

            switch (input)
            {
                case int number:
                    number += 1;
                    break;
                case object[] _:
                    // ignore
                    break;
            }
        }

    }
}
