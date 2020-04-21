using System;
namespace ShapesTest
{
    public class Rectangle : Figure
    {
        

        public Rectangle(double _x, double _y, string _name) : base (_x, _y, _name)
        {
            
        }
         public override void area()
        {
            Console.Write("Enter the length: ");
            X = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the breath: ");
            Y = Convert.ToDouble(Console.ReadLine());
            Console.Write($"The area of rectangle length: {X} and breath: {Y} is {X * Y}");
        }
    }
}