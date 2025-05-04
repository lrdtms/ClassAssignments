  using System;

public class NumberChecker
{ 
  
  public void CheckIfNumberIsEvenOrOdd()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        int number;

        bool inputNumber = int.TryParse(input, out number);

        if (inputNumber)
        {
            int remainder = number % 2;

            if (remainder == 1)
            {
                Console.WriteLine($"This number is odd = {number}");
            }
            else
            {
                Console.WriteLine($"This number is even = {number}");
            }
        }
          else
        {
            Console.WriteLine("Invalid number. Please enter a valid integer.");
        }
    }
}