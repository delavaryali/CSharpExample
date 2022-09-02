
//*****************Yield****************
yieldClass.ShowGalaxies();





//*****************Indexing  class****************
var week = new DayCollection();
Console.WriteLine(week["Fri"]);

try
{
    Console.WriteLine(week["Fri"]);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine($"Not supported input: {e.Message}");
}




//**********array****************
// Declare a single-dimensional array of 5 integers.
int[] array1 = new int[5];

// Declare and set array element values.
int[] array2 = new int[] { 1, 3, 5, 7, 9 };

// Alternative syntax.
int[] array3 = { 1, 2, 3, 4, 5, 6 };




//**************overloading****************
display(100);
//display(100, 200);



// method with one parameter
void display(int a)
{
    Console.WriteLine("Arguments: " + a);
}

// method with two parameters
// void display(int a, int b)
// {
//     Console.WriteLine("Arguments: " + a + " and " + b);
// }



