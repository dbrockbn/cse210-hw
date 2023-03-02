using System;

namespace prep5_shape
{
    public class Square : Shape
    {
        private double _side;
        //public Square(int color)
        //: base (color)
        public Square(string color, double side) : base (color)
        {
           _side = side;
        }
        //private int _side = 0;
        public override double GetArea()
        {
            return _side * _side;
        }
    }


}
// Make sure this class inherits from the base class.
// Create a constructor that accepts the color and the side, and then call the base constructor with the color.
// Create the _side attribute as a private member variable.
// Override the GetArea() method from the base class and fill in the body of this function to return the area.
// Test the Square class