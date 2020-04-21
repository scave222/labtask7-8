using System;
namespace ShapesTest
{
    public class Triangle : Figure
    {
        

        public Triangle(double _x, double _y, string _name) : base (_x, _y, _name)
        {
            
        }
         public override void area()
        {

             Console.Write("Enter the base: ");
            X = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height: ");
            Y = Convert.ToDouble(Console.ReadLine());   
            Console.Write($"The area of trangle with base: {X} and height: {Y} is {(X * Y) * 0.5}");
        }
    }
}