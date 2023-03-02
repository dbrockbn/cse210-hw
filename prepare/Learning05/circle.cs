using System;

namespace prep5_shape
{
    public class Circle : Shape
    {
        private double _radius: //must include private

        public Circle(string color, double radius) : base (color) //must include both arguemtns for circle and back to base
            _radius = radius;
        }
        public override double GetArea()               //need to include override so it can be changed in each class
        {
            return _radius * _radius * Math.PI;     // do we not need to import math?
        }
}