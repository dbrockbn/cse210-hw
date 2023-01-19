using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number? ");
        //int magic= Console.ReadLine();
        //Console.WriteLine("what is your guess?");
        //int guess= Console.ReadLine();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
        //if (guess = magic)
        //{
        //    Console.WriteLine("You guessed it!");
    
        //}
        //else (guess < magic);
        //{
        //    Console.WriteLine("Higher")
        //}  
        //else (guess > magic);
        //{
        //    Console.WriteLine("Lower")
       // }