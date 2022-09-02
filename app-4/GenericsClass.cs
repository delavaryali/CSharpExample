class DataStore<T>
{
    public T Data { get; set; }
}


public class GenericsClass
{

    public void Run()
    {
        DataStore<string> strStore = new DataStore<string>();
        strStore.Data = "Hello World!";
        //strStore.Data = 123; // compile-time error

        DataStore<int> intStore = new DataStore<int>();
        intStore.Data = 100;
        //intStore.Data = "Hello World!"; // compile-time error

        KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
        kvp1.Key = 100;
        kvp1.Value = "Hundred";

        KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
        kvp2.Key = "IT";
        kvp2.Value = "Information Technology";
    }

}


