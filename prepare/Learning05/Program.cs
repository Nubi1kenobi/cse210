using System;
using System.Reflection.Metadata;
namespace Learning05
{
    class Program
        {
            static void Main(string[] args)
                {
                    Console.Clear();
                    Console.WriteLine("Hello Learning05 World!");
                    Square square1 = new Square("purple", 2);
                    Rectangle rectangle2 = new Rectangle("blue", 4, 2);
                    Circle circle3 = new Circle("green", 3);
                    Console.WriteLine($"Square Area: {square1.GetArea()}");
                    Console.WriteLine($"Rectangle Area: {rectangle2.GetArea()}");
                    Console.WriteLine($"Circle Area: {circle3.GetArea()}");
                    Console.WriteLine("Now we can build the 'Shape List'.");
                    List<Shape> multitudeOfShapes = new List<Shape>();
                    multitudeOfShapes.Add(square1);
                    multitudeOfShapes.Add(rectangle2);
                    multitudeOfShapes.Add(circle3);

                    foreach (Shape shapeLister in multitudeOfShapes)
                        {
                             Console.WriteLine($"Color: {shapeLister.GetColor()}, Area: {shapeLister.GetArea()}");                   
                             
                             
                        }

                }
        }


}
