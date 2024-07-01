using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8
{
    internal class AttributesOnLocalFunctions
    {
        public void run()
        {
            static void DoAction()
            {
                // DoAction

                Console.WriteLine("DoAction...");
            }

            #if DEBUG
                DoAction();
            #endif






            [Conditional("DEBUG")]
            static void DoAction2()
            {
                // Do Action Here

                Console.WriteLine("Do Action...");
            }

            DoAction2();


        }
    }
}
