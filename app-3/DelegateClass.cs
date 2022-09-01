

public class DelegateClass
{

    public delegate void MyDelegate(string msg); // declare a delegate

    public void DelegateInvok()
    {
        // set target method
        MyDelegate delegateEX = new MyDelegate(MethodA);
        // or 
        //MyDelegate delegateEX = MethodA;
        // or set lambda expression 
        //MyDelegate delegateEX = (string msg) => Console.WriteLine(msg);

        delegateEX.Invoke("Hello World!");
        // or 
        delegateEX("Hello World!");



        /* MyDelegate del1 = MethodA;
        MyDelegate del2 = MethodB;

        MyDelegate del = del1 + del2; // combines del1 + del2
        del("Hello World");

        MyDelegate del3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        del += del3; // combines del1 + del2 + del3
        del("Hello World");

        del = del - del2; // removes del2
        del("Hello World");

        del -= del1 // removes del1
        del("Hello World"); */
    }

    // target method
    static void MethodA(string message)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
    }

    static void MethodB(string message)
    {
        Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
    }
}

