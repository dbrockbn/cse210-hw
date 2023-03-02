using System;

namespace prep5_shape
{
    public class Rectangle : Shape
    {
        private double _length;
        private double _width; ///I had put side but width is correct
        public Rectangle(string color, double length, double width) : base (color)
        {
            _length = length;
            _width = width;
        }

        public override double GetArea()
        {
            return _length * _width;
        }

    }

}