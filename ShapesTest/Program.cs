using System;

namespace ShapesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2, 3, "Rectangle");
            Square square = new Square(4, 4, "Square");
            Triangle triangle = new Triangle(5, 5, "Triangle");
            Cube cube = new Cube(2, 2, "Cube");

            Console.Write("Choose a shape you want to calculate the area: ");
            string shape = Console.ReadLine();

            if(shape == "Rectangle")
            {
                rectangle.area();
            }
            if(shape == "Square")
            {
                square.area();
            }
            if(shape == "Triangle")
            {
                triangle.area();
            }
            if(shape == "Cube")
            {
                cube.area();
            }

        }
    }
}
