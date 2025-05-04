// See https://aka.ms/new-console-template for more information
// take in numerical value 
//store and chech if that value is odd or even 
//it need to tell us what the number is and whether its odd or even

using System;

class Program
{
    static void Main(string[] args)
    {
        NumberChecker checker = new NumberChecker();  // Create an object of the class
        checker.CheckIfNumberIsEvenOrOdd();           // Call the method
    }
}


//Console.WriteLine(remainder);