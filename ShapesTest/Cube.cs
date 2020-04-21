using System;
namespace ShapesTest
{
    public class Cube : Figure
    {
        
    
        public Cube(double _x, double _y, string _name) : base (_x, _y, _name)
        {
            
        }
         public override void area()
        {
            Console.Write("Enter the length: ");
            X = Convert.ToDouble(Console.ReadLine());
            Console.Write($"The area of a cube with length: {X} is {6 * (Math.Pow(X,2))}");
        }
    }
}