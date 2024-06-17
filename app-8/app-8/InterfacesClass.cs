 interface IPolygon {
    // method without body
    void calculateArea(int a, int b);

  }

  interface IColor {

    void getColor();
  }
   
  // implements two interface
  class Rectangle2 : IPolygon, IColor {


    // implementation of IPolygon interface
    public void calculateArea(int a, int b) {

      int area = a * b;
      Console.WriteLine("Area of Rectangle: " + area);
    }

    // implementation of IColor interface
    public void getColor() {

      Console.WriteLine("Red Rectangle");
            
    }
  }