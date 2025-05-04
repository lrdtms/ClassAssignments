// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.ComponentModel.DataAnnotations;

string sentence = Console.ReadLine();
string[] words = sentence.Split(' '); // splits the sentence into words by spaces
string longestWord = string.Empty;

// Print each word
foreach (string word in words)
{
   // int largestNum = word.Length;
   
   if (word.Length > longestWord.Length)
            {

                longestWord = word;
                
            }
}
Console.WriteLine(longestWord);