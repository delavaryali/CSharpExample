using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_7
{
    public static class RangesAndIndices
    {
        public static void Run()
        {
            var integerArray = new int[3];
            var lastItem = integerArray[integerArray.Length - 1];
            var secondToLast = integerArray[integerArray.Length - 2];

            var integerList = integerArray.ToList();
            integerList.Last();

            var lastItem2 = integerArray[^1];

            var words = new string[]
 {
                // index from start    index from end
    "The",      // 0                   ^9
    "quick",    // 1                   ^8
    "brown",    // 2                   ^7
    "fox",      // 3                   ^6
    "jumped",   // 4                   ^5
    "over",     // 5                   ^4
    "the",      // 6                   ^3
    "lazy",     // 7                   ^2
    "dog"       // 8                   ^1
 };              // 9 (or words.Length) ^0


            Console.WriteLine($"The last word is {words[words.Length - 1]}");
            Console.WriteLine($"The last word is {words[^1]}");

            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(a[a.Length - 2]); // will write 8 on console.
            Console.WriteLine(a[^2]); // will write 8 on console.

            Index i5 = 5;
            Console.WriteLine(a[i5]);        //will write 5 on console.

            Index i2fromEnd = ^2;
            Console.WriteLine(a[i2fromEnd]); // will write 8 on console.



            var numbers = Enumerable.Range(1, 10).ToArray();

            var (start, end) = (1, 7);
            var length = end - start;

            // Using LINQ
            var subset1 = numbers.Skip(start).Take(length);

            // Or using Array.Copy
            var subset2 = new int[length];
            Array.Copy(numbers, start, subset2, 0, length);




            var myArray = new string[] { "Item1", "Item2", "Item3", "Item4", "Item5" };

            var fromIndexToX = myArray[1..3]; // = [Item2, Item3]
            var fromIndexToXFromTheEnd = myArray[1..^1]; // = [ "Item2", "Item3", "Item4" ]
            var fromAnIndexToTheEnd = myArray[1..]; // = [ "Item2", "Item3", "Item4", "Item5" ]
            var fromTheStartToAnIndex = myArray[..3]; // = [ "Item1", "Item2", "Item3" ]
            var entireRange = myArray[..]; // = [ "Item1", "Item2", "Item3", "Item4", "Item5" ]



            var myArray2 = new string[] { "Item1", "Item2", "Item3", "Item4", "Item5" };

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(myArray2[i]);
            }

            foreach (var item in myArray2[1..4]) // = [ "Item2", "Item3", "Item4" ]
            {
                Console.WriteLine(item);
            }

            int[] _numbers = Enumerable.Range(1, 10).ToArray();

            var skip2CharactersAndTake2Characters = _numbers[2..4]; // صرفنظر کردن از دو عنصر اول و سپس انتخاب دو عنصر
            var skipFirstAndLastCharacter = _numbers[1..^1]; // صرفنظر کردن از دو عنصر اول و آخر
            var last3Characters = _numbers[^3..]; // انتخاب بازه‌ای شامل سه عنصر آخر
            var first4Characters = _numbers[0..4]; // دریافت بازه‌ای از 4 عنصر اول
            var rangeStartFrom2 = _numbers[2..]; // دریافت بازه‌ای شروع شده از المان دوم تا آخر
            var skipLast3Characters = _numbers[..^3]; // صرفنظر کردن از سه المان آخر
            var rangeAll = _numbers[..]; // انتخاب کل بازه




            _ = _numbers.Skip(10).Take(5);
            _ = _numbers.Take(10..15);
            _ = _numbers.Take(^10..);
            _ = _numbers.ElementAt(^1);



            Console.WriteLine("123456789"[1..4]); // Would output 234

            var helloWorldStr = "Hello, World!";

            var hello = helloWorldStr[..5];
            Console.WriteLine(hello); // Output: Hello

            var world = helloWorldStr[7..];
            Console.WriteLine(world); // Output: World!

            var world2 = helloWorldStr[^6..]; // Take the last 6 characters
            Console.WriteLine(world); // Output: World!


        }
    }

    class RangesAndIndices2
    {
        private static readonly int[] _numbers = Enumerable.Range(1, 10).ToArray();
        static void Print(Range range) => Console.WriteLine($"{range} => {string.Join(", ", _numbers[range])}");

        static void Run()
        {
            Print(1..3); // 1..3 => 2, 3
            Print(..3);      // 0..3 => 1, 2, 3
            Print(3..);      // 3..^0 => 4, 5, 6, 7, 8, 9, 10
            Print(1..^1);    // 1..^1 => 2, 3, 4, 5, 6, 7, 8, 9
            Print(^2..^1);   // ^2..^1 => 9
        }
    }
}
