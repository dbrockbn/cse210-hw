using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        //Console.WriteLine("Enter a list of numbers. Type 0 when finished");
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

        }

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //string userinput;

       //do
       // {
        //    Console.Write("Enter number?: ");
        //    userinput = Console.ReadLine();
        //} while (userinput != "0");

        //foreach (string num in input)
        //{
        //    Console.WriteLine(num);    
       // }
        //count = Console.WriteLine(num.Count);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The Largest number is: {max}");
   }
