using System;

namespace prep5_shape   // In a new file, create the Shape class.
{   
    public abtract class Shape  //needed to add abstract to the class
    {
        private string _color;    //this string needed to be private not public
        //public string GetColor()
        public Shape(string color)
        {
            _color = color;
        }
    
       /// return _color;
    
    // public void SetColor(string color)
    // {
    //     _color = color;
    // }
    //public int _area;
    public abstract double GetArea(); // not public virtual GetArea()
}
}
// Add the color member variable and a getter and setter for it.
// Create a constructor that accepts the color and set its.
// Create a virtual method for GetArea().
// Create the Square class
// In a new file, create the Square class.
// Make sure this class inherits from the base class.
// Create a constructor that accepts the color and the side, and then call the base constructor with the color.
// Create the _side attribute as a private member variable.
// Override the GetArea() method from the base class and fill in the body of this function to return the area.
// Test the Square class
// Return to the Main method in Program.cs to test your code.
// Create a Square instance, call the GetColor() and GetArea() methods and make sure they return the values you expect.
// Create the Rectangle and Circle classes
// Repeat the steps above for the Rectangle and Circle classes, putting them each in their own files, storing the necessary variables, and overriding the GetArea() for each.
// Test these classes back in Main and make sure they work as expected.
// Build a List
// In your Main method, create a list to hold shapes (Hint: The data type should be List<Shape>).
// Add a square, rectangle, and circle to this list.
// Iterate through the list of shapes. For each one, call and display the GetColor() and GetArea() methods