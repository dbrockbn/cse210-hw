using System;
using System.Collections.Generic;
public class PromptGenerator{
string entryList = new List<string>(5);
entry.Add("Who was the most interesting person I interacted with today?");
entry.Add("What was the best part of my day?");
entry.Add("How did I see the hand of the Lord in my life today?");
entry.Add("What was the strongest emotion I felt today?");
entry.Add("If I had one thing I could do over today, what would it be?");
string[] entryArray = entryList.ToArray();
Array.ForEach(entryArray, Console.WriteLine);

}
// Instantiate random number generator.
private readonly Random _random = new Random();

// Generates a random number within a range.
public int RandomNumber(int 1, int 5)
{
  return _random.Next(1, 5);
}


