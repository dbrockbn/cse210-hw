using System;

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
                numbers.runActivity(userNumber);
            }
        }
            if (userNumber == 1)
            {

            }
            if (userNumber == 2){

            }
            if (userNumber == 3){

            }
            if (userNumber == 4) {

            }
            numbers.runCountdown(userTime);
            numbers.runSpinner(userTime);
            numbers.displayStartMessage(startProgram);
            numbers.displayEndMessage(endProgram);
            numbers.getTime((startProgram)-(endProgram));


class activity 