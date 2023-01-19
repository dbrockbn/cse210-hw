using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        int magic= Console.ReadLine();
        Console.WriteLine("what is your guess?");
        int guess= Console.ReadLine();

        if (guess = magic)
        {
            Console.WriteLine("You guessed it!");
    
        }
        else (guess < magic);
        {
            Console.WriteLine("Higher")
        }  
        else (guess > magic);
        {
            Console.WriteLine("Lower")
        }
}