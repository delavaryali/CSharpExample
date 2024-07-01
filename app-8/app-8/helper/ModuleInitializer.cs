using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace app_8.helper
{
    internal class ModuleInitializer
    {
    }

    //متدي است که در زمان بارگذاري اوليه‌ي يک اسمبلي، به صورت خودکار اجرا مي‌شود
    internal static class TestModuleInitializer
    {
        [ModuleInitializer]
        public static void MyModuleInitializer()
        {
            // put your module initializer here
        }
    }

}
