// See https://aka.ms/new-console-template for more information
//Create a calculator that takes input and produces output
using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();     // Create an object of the Calculator class
        calc.DoCalculation();                   // Call the method
    }
}