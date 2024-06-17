using System.Net;

public class ExceptionFiltering
{


    //    try
    //{
    //    // some code to check  ...
    //}
    //catch (InvalidOperationException ex)
    //{
    //    // do your handling for invalid operation ...
    //}
    //catch (IOException ex)
    //{
    //    // do your handling for IO error ...
    //}


    public static async Task<string> MakeRequest()
    {
        var client = new HttpClient();
        var streamTask = client.GetStringAsync("https://localHost:10000");
        try
        {
            var responseText = await streamTask;
            return responseText;
        }
        catch (HttpRequestException e) when (e.Message.Contains("301"))
        {
            return "Site Moved";
        }
        catch (HttpRequestException e) when (e.Message.Contains("404"))
        {
            return "Page Not Found";
        }
        catch (HttpRequestException e)
        {
            return e.Message;
        }
    }

    //    try
    //{
    //    var request = WebRequest.Create("http://www.google.coom/");
    //    var response = request.GetResponse();
    //}
    //catch (WebException we)
    //{
    //    if (we.Status == WebExceptionStatus.NameResolutionFailure)
    //    {
    //        //handle DNS error
    //        return;
    //    }
    //    if (we.Status == WebExceptionStatus.ConnectFailure)
    //{
    //    //handle connection error
    //    return;
    //}

    //throw;
    //}


    //    try
    //{
    //    var request = WebRequest.Create("http://www.google.coom/");
    //    var response = request.GetResponse();
    //}
    //catch (WebException we) when (we.Status == WebExceptionStatus.NameResolutionFailure)
    //{
    //    //Handle NameResolutionFailure Separately
    //}
    //catch (WebException we) when (we.Status == WebExceptionStatus.ConnectFailure)
    //{
    //    //Handle ConnectFailure Separately
    //}
}




