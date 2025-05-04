// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int[] numbers = new int[] {2, 3, 6, 9, 11, 13};

for (int i = 0; i < numbers.Length; i++)
{
int oddNumber = numbers[i] % 2;

if (oddNumber == 1)
{
    Console.WriteLine($"This is odd : {numbers[i]}");
}
else
{
    Console.WriteLine($"This is even : {numbers[i]}");
}
}




/*
int oddNumber = numbers[1] % 2;

if (oddNumber == 1)
{
    Console.WriteLine("this is odd");
}
*/
