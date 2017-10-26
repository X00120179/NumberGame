using System;

// Namespace
namespace NumberGame
{
    // Main class
    class Program
    {
        // Entry point method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to get info

            GreetUser(); // Ask for users name and greet user

            while (true)
            {
                // Create a new random object
                Random random = new Random();

                // Put the random number between 1 and 10 into a variable
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user to guess a number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColourMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColourMessage(ConsoleColor.Red, "Wrong nummber, please try again!");
                    }
                }

                // Output success message
                PrintColourMessage(ConsoleColor.Yellow, "You are correct! You guessed it!");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

                // Hold window
                Console.ReadLine();
            }
        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Start here - set app vars
            string appName = "Number Game App";
            string appVersion = "1.0.0";
            string appAuthor = "Lee Healy";

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            // Display app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset colour
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            // Greet user
            Console.WriteLine("\nHello {0}, let's play the number game!", inputName);
        }

        // Print colour message
        static void PrintColourMessage(ConsoleColor colour, string message)
        {
            // Change text colour
            Console.ForegroundColor = colour;

            // Tell user it's not a number
            Console.WriteLine(message);

            // Reset colour
            Console.ResetColor();
        }
    }
}
