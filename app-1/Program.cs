// See https://aka.ms/new-console-template for more information


//***********out****************
//نیازی به مقدار دهی اولیه ندارد
int initializeInMethod;
OutArgExample(out initializeInMethod);
Console.WriteLine(initializeInMethod);     // value is now 44

//****************ref***************
//باید مقدار دهی اولیه شده باشد
int number = 1;
Method(ref number);
Console.WriteLine(number);


//*************params*********************
UseParams(1, 2, 3, 4);
UseParams2(1, 'a', "test");


//*************in************************
//نباید متغییر ویرایش شود
int readonlyArgument = 44;
InArgExample(readonlyArgument);
Console.WriteLine(readonlyArgument);     // value is still 44



void OutArgExample(out int number)
{
    number = 44;
}

void Method(ref int refArgument)
{
    refArgument = refArgument + 44;
}

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
