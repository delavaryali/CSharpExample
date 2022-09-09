using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# 6
namespace app_7
{
    public static class NullConditionalOperators
    {
        public static void Run()
        {
            //null - coalescing operator

            //if (data == null)
            //{
            //    data = "value";
            //}
            //var result = data;

            string? data = null;
            var result = data ?? "value";
            Console.WriteLine(result);

            Console.WriteLine(data);
            Console.WriteLine(result);








            var webData = new WebRequest().GetDataFromWeb("https://www.dntips.ir/");
            if (webData != null && webData.Result != null)
            {
                Console.WriteLine(webData.Result);
            }

            if (webData?.Result != null)
            {
                Console.WriteLine(webData.Result);
            }

            //var code = webData?.Code;
            //if (webData?.Code > 0)
            //{
            //}

            //int count = response?.Results?.Count ?? 0;

            int? x = 10;
            //var value = x?.Value; // invalid
            Console.WriteLine(x?.ToString());








            //if (response != null && response.Results != null && response.Results.Addresses != null
            //    && response.Results.Addresses[0] != null && response.Results.Addresses[0].Zip == "63368")
            //{

            //}

            //if (response?.Results?.Addresses?[0]?.Zip == "63368")
            //{

            //}







            //if (variable == null)
            //{
            //    variable = expression; // C# 1..7
            //}

            //variable ??= expression; // C# 8


        }
    }

    class Response
    {
        public string? Result { set; get; }
        public int Code { set; get; }
    }


    class WebRequest
    {
        public Response GetDataFromWeb(string url)
        {
            // ...
            return new Response { Result = null };
        }
    }
}
