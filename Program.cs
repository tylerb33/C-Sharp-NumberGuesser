using System;

namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method. Void means that the method won't return anything. Static means there are no 'instances'.
        static void Main(string[] args)
        {
            // Run GetAppInfo function to start
            GetAppInfo();

            // Run GreetUser
            GreetUser();

            while (true)
            {


                // Init correct number
                // int correctNumber = 7;
                // Create a new Random object
                Random random = new Random();
                int correctNumber = random.Next(1, 11);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is incorrect
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "That is not a number. Please input a number.");

                        // Keep going
                        continue;

                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!!!");

                // Ask to play again
                Console.WriteLine("Do you want to play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else 
                {
                    return;
                }

            }
        }

        static void GetAppInfo() {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Tyler Barnett";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask user's name and greet
        static void GreetUser() {
            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game.", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message ) {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user it's not a number
            Console.WriteLine(message);
            // Reset text color
            Console.ResetColor();
        }
    }
}
