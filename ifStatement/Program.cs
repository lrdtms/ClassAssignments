// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
/*{
Console.WriteLine("Bob's Big Giveaway");
Console.Write("Choose a door: 1, 2 or 3: ");

string userValue = Console.ReadLine();

string message = ""; // adding his negates the console.writeline within the if staements
*/
/*if (userValue == "1")
{
    message = "You won a new car!";
   // Console.WriteLine(message);
}

else if (userValue == "2")
{
    message = "You won a boat!";
    //Console.WriteLine(message);
}

else if (userValue == "3")
{
    message = "You won a cat!";
   // Console.WriteLine(message);
}

else // incase noting is true
{
    message = "Sorry, we didnt understand.";
    //Console.WriteLine(message);
}
*/

//Below is an optimized version of the above

/*if (userValue == "1")
    message = "You won a new car!";
else if (userValue == "2")
    message = "You won a boat!";
else if (userValue == "3")
    message = "You won a cat!";
else //The curly brackets are only needed for the string interpolation
{
    message = "Sorry, we didnt understand.";
    //message = message + "You lose!!!";
    message += "You lose!!!"; // the operator adds and assigns the string to the variable
}
*/

//Further optimized version

Console.WriteLine("Bobs Big Giveaway");
Console.Write("Choose a door: 1, 2, or 3: ");
string userValue = Console.ReadLine();

string message = (userValue == "1") ? "Boat" : "strand of lint";
// This is a ternary operator — a shorthand for an if...else statement.
// If userValue is "1", then message becomes "Boat"
// Otherwise, message becomes "strand of lint"

/*Console.Write("You won a ");
Console.Write(message);
Console.Write(".");
*/

Console.Write($"You won a {message}.");

Console.ReadLine();

/*Console.WriteLine(message);
Console.ReadLine();*/
//}