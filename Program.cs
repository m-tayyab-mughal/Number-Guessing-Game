class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");

        do
        {
            PlayGame();
            Console.WriteLine("Do you want to play again?");
            Console.WriteLine("Press ENTER to play again or press SPACE to exit.");

        } while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);

        Console.WriteLine("\nThank you for playing!");
    }

    static void PlayGame()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 31);
        int userGuess = 0;
        int tries = 0;

        Console.WriteLine("\nI have picked a number between 1 and 30.");
        Console.WriteLine("Try to guess it!");

        while (userGuess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out userGuess);

            if (!isNumber)
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            if (userGuess < 1 || userGuess > 30)
            {
                Console.WriteLine("Please guess a number between 1 and 30.");
                continue;
            }

            tries++;

            if (userGuess > numberToGuess)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your guess is too big. Try a smaller number.");

            }
            else if (userGuess < numberToGuess)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Your guess is too small. Try a bigger number.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Congratulations! You guessed the number in {tries} tries.\n");
            }
            Console.ResetColor();
        }
    }
}
