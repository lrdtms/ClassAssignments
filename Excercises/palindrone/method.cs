using System;

public class Palindrone
{
   public void checkPalindrone()
   {
    Console.Write("Type a word:");

string word = Console.ReadLine();
string frontWord = "";
string backWord = "";

for (int i = 0; i < word.Length; i++)
{
    frontWord += word[i];
}

for (int i = word.Length - 1; i >= 0; i--)
{
    backWord += word[i];
}

int comparison = frontWord.CompareTo(backWord);

if (comparison == 0)
{
    Console.WriteLine($"{word} is a palindrone.");
}

else
{
    Console.WriteLine($"{word} is not a palindrone.");
}
   }
}
