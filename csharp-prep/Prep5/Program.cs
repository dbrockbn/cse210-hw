using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = DisplayName();
        int number = EnterNumber(); 

        int squaredNumber = square(number);

        DisplayResult(userName, squaredNumber);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string DisplayName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int EnterNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");  
        int number= int.Parse(Console.ReadLine());

        return number;
    }

    static int square(int number)
    {
        int square = number * number;
        return square;
    }      

    static void DisplayResult(string userName, int square)
    {
    Console.WriteLine($"{userName}, the square of your number is {square}");
    }
}