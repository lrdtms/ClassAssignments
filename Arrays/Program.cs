﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
int[] numbers = new int[5];

numbers[0] = 4;
numbers[1] = 8;
numbers[2] = 15;
numbers[3] = 16;
numbers[4] = 23;

Console.WriteLine(numbers[1]);
*/

// int[] numbers = new int[] {4, 8, 15, 16, 23, 42};

string[] names = new string[] {"Eddie", "Alex", "Michael", "David-Lee"};

/*
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}
*/

/*
foreach ( string name in names)
{
    Console.WriteLine(name);
}
*/

String zig = "you can get what you want when " + 
             "help others my bru";

char[] charArray = zig.ToCharArray();
Array.Reverse(charArray);

foreach (char zigChar in charArray)
{
    Console.Write(zigChar);
}