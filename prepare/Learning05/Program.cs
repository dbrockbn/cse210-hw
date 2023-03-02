using System;

namespace prep5_shape
{
class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();    //misssing shapes = new List<Shape>();
        
        Square s1 = new Square( "Purple", 4);  //I didn't realize I needed to make new variables for the square
        shapes.Add(s1);

        Rectangle s2 = new Rectangle( "Yellow", 6, 12);
        shapes.Add(s2);

        Circle s3 = new Circle("Pink", 2);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();           //missing GetColor method

            double area = s.GetArea();

            Console.WriteLine( $"The {color} shape has an area of {area}." );
        }
    }
}
}