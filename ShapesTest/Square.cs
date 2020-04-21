using System;
namespace ShapesTest
{
    public class Square : Figure
    {

        public Square(double _x, double _y, string _name) : base (_x, _y, _name)
        {
            
        }
         public override void area()
        {
            Console.Write("Enter the length: ");
            X = Convert.ToDouble(Console.ReadLine());
            Console.Write($"The area of square length: {X} and breath: {X} is {X * X}");
        }
    }
}