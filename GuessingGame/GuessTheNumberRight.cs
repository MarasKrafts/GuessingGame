namespace GuessingGame
{
    internal class GuessTheNumberRight
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I have selected a random number between 1 and 100. Try to guess it.");

            // Generate a random number between 1 and 100
            Random random = new Random();
            int targetNumber = random.Next(1, 101);

            int attempts = 0;
            int guess;

            do
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                // Check if the input is a valid integer
                if (int.TryParse(input, out guess))
                {
                    attempts++;

                    // Check if the guess is correct
                    if (guess == targetNumber)
                    {
                        Console.WriteLine($"Congratulations! You guessed the correct number in {attempts} attempts.");
                        break;
                    }
                    else
                    {
                        // Provide a hint whether the target number is higher or lower
                        Console.WriteLine(guess < targetNumber ? "Too low. Try again!" : "Too high. Try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            } while (true);

            Console.WriteLine("Thanks for playing!");
            Console.ReadLine(); // Wait for user input to close the console
        }
    }
}
