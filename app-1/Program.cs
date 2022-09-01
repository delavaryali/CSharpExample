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