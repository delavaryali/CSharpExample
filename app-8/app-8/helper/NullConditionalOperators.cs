using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# 6

public static class NullConditionalOperators
{
    public static void Run()
    {
        //null - coalescing operator

        

        //در اين حالت اگر  يا سمت چپ عملگر، نال باشد، مقدار  (سمت راست عملگر) بازگشت داده خواهد شد؛ 
        string? data = null;
        var result = data ?? "value";
        Console.WriteLine(result);

        Console.WriteLine(data); //value
        Console.WriteLine(result);//value

        //خلاصه شده‌ي چند سطر ذيل است
        //if (data == null)
        //{
        //    data = "value";
        //}
        //var result = data;





        var webData = new WebRequest().GetDataFromWeb("https://www.dntips.ir/");

        if (webData != null && webData.Result != null)
        {
            Console.WriteLine(webData.Result);
        }


        //در اين حالت ابتدا مقدار سمت چپ عملگر بررسي خواهد شد. اگر مقدار آن مساوي نال بود، در همينجا کار خاتمه يافته و نال بازگشت داده مي‌شود. در غير اينصورت کار بررسي زنجيره‌ي جاري ادامه خواهد يافت
        if (webData?.Result != null)
        {
            Console.WriteLine(webData.Result);
        }




        //if (x != null)
        //{
        //    x.Dispose();
        //}
        //خلاصه
        //x?.Dispose();





        var code = webData?.Code;
        if (webData?.Code > 0)
        {
        }

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

        string? vari = null;
        vari ??= "ali";
        Console.WriteLine(vari);


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

