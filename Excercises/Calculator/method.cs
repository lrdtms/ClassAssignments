// Calculator.cs
using System;

public class Calculator
{
    public void DoCalculation()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter an operator (+, -, x, /): ");
        string op = Console.ReadLine();

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"Result: {result}");
                break;

            case "-":
                result = num1 - num2;
                Console.WriteLine($"Result: {result}");
                break;

            case "x":
                result = num1 * num2;
                Console.WriteLine($"Result: {result}");
                break;

            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero!");
                }
                break;

            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}