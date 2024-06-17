
// base class
class Animal
{

    public string name;

    public void display()
    {
        Console.WriteLine("I am an animal");
    }
    public virtual void eat()
    {

        Console.WriteLine("I eat food");
    }

}

// derived class of Animal 
class Dog : Animal
{
    public void getName()
    {
        Console.WriteLine("My name is " + name);
    }

    public override void eat()
    {
        // call method from Animal class
        base.eat();

        Console.WriteLine("I eat Dog food");
    }
}