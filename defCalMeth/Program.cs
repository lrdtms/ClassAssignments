// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Formats.Asn1;
using System.IO.Pipelines;
using System.Net;

namespace HelperMethods
{
    class Program
    {
        static string Output;
        static void Main(string[] args)
        {


/*
            Console.WriteLine("The Name Game");

            Console.Write("Whats your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("Whats your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("What city are you from? ");
            string city = Console.ReadLine();

            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = "";

            foreach (char item in firstNameArray)
            {
                result += item;
            }

            result += " ";
             foreach (char item in lastNameArray)
            {
                result += item;
            }

            result += " ";

             foreach (char item in cityArray)
            {
                result += item;
            }

            Console.WriteLine("Results: " + result);
*/
            nameGame();
            
        }

        private static void title()
        {
            Console.WriteLine("The Name Game");
        }
        private static void question()
        {
            string question1 = "Whats your first name? ";
            string question2 = "Whats your last name? ";
            string question3 = "What city are you from? ";
            string[] questions = new string[] { question1, question2, question3 };
             string[] answers = new string[questions.Length];
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                answers[i] = Console.ReadLine();
                Output += answers[i] + " ";  // Store user input
            }
        }

        private static void quesitonOutput()
        {
            char[] questionOutputArray = Output.ToCharArray();
            Array.Reverse(questionOutputArray);
            string result = "";
             foreach (char answer in questionOutputArray )
            {
                result += answer;
            }
             Console.WriteLine("Results: " + result);
        }
        private static void nameGame()
        {
            string choice;

            Console.WriteLine("Would you like to proceed to game?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            choice = Console.ReadLine();


            if (choice == "1"  ||  choice == "yes" || choice == "1.Yes")
            {
            title();
            question();
            quesitonOutput();
            Console.ReadKey();
            }
             else
            {
                Console.WriteLine("Thank you for participating.");
            }
        }
    }
}