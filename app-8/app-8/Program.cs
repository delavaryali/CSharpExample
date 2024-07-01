// See https://aka.ms/new-console-template for more information
using app_8;

//Ref Returns and Ref Locals
//Generalized Async Return Types
//Binary literals and digit separators
//Span 
//Value Types + in
//Async Streams
//Immutable Record
//Covariant 





//***********out****************
//نیازی به مقدار دهی اولیه ندارد
//با استفاده از واژه‌ي کليدي ref، مي‌توان يک مقدار را هم به تابع ارسال کرد و هم از آن دريافت نمود.
//اما اگر تنها قرار است مقداري از تابع بازگشت داده شود، مي‌توان از متغيرهاي out استفاده کرد
using System.Runtime.CompilerServices;

Linq linq = new();
linq.run();


int initializeInMethod;
OutArgExample(out initializeInMethod);
Console.WriteLine(initializeInMethod);     // value is now 44

void OutArgExample(out int number)
{
    number = 44;
}

//****************ref***************
//باید مقدار دهی اولیه شده باشد
int number = 1;
Method(ref number);
Console.WriteLine(number);


void Method(ref int refArgument)
{
    refArgument = refArgument + 44;
}


//*************params*********************
UseParams(1, 2, 3, 4);
UseParams2(1, 'a', "test");


static void UseParams(params int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write(list[i] + " ");
    }
    Console.WriteLine();
}

static void UseParams2(params object[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write(list[i] + " ");
    }
    Console.WriteLine();
}



//*************in************************
//نباید متغییر ویرایش شود
int readonlyArgument = 44;
InArgExample(readonlyArgument);
Console.WriteLine(readonlyArgument);     // value is still 44

void InArgExample(in int number)
{
    // Uncomment the following line to see error CS8331
    //number = 19;
}




// public
// کد برای همه کلاسها قابل دسترسی است
// همچنین در همان اسمبلی و از اسمبلی های دیگر به عنصر public دسترسی وجود دارد.

// private
// کد فقط در همان کلاس قابل دسترسی است

// protected
// این کد در همان کلاس یا در کلاسی قابل دسترسی است که از آن کلاس به ارث رسیده است. 

// internal
// در این حالت عنصر فقط درون پروژه جاری قابل دسترسی است

//  protected internal
// در واقع protected internal ترکیب دو سطح دسترسی protected و internal است.
//  Member هایی با این سطح دسترسی، به دلیل internal بودن فقط در همان اسمبلی قابل دسترس هستند.
// همزمان به دلیل protected بودن، فقط محدود به خود Data Type و فرزندان آن خواهند بود.
// بنابر این فرزندان خارج از اسمبلی قادر به رویت این Member ها نخواهند بود.





// public: Access is not restricted.
// protected: Access is limited to the containing class or types derived from the containing class.
// internal: Access is limited to the current assembly.
// protected internal: Access is limited to the current assembly or types derived from the containing class.
// private: Access is limited to the containing type.
// private protected: Access is limited to the containing class or types derived from the containing class within the current assembly.







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






//***************inheritance********************
// object of derived class
Dog labrador = new Dog();

// access field and method of base class
labrador.name = "Rohu";
labrador.display();


// access method from own class
labrador.getName();





//****************Polymorphism**********************
var shapes = new List<Shape>
{
    new Rectangle(),
    new Triangle(),
    new Circle()
};

foreach (var shape in shapes)
{
    shape.Draw();
}


//******************abstract********************
var o = new DerivedClass();
o.AbstractMethod();
Console.WriteLine($"x = {o.X}, y = {o.Y}");
// Output: x = 111, y = 161


//******************interface********************
Rectangle2 r1 = new Rectangle2();

r1.calculateArea(100, 200);
r1.getColor();



//******************Overloading********************
OverloadingClass MD = new OverloadingClass(2001, 7, 16);
Console.WriteLine(MD + 10);
//output:2001-07-26



//******************Delegate********************
DelegateClass del = new DelegateClass();
del.DelegateInvok();

//*******************Enumeration*****************
public enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }


//******************Event********************







