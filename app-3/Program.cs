
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
