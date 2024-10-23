using System;
using System.Collections.Generic;

class HigherOrLowerGame
{
    static void Main()
    {
        // Display a welcome message to introduce the game
        DisplayWelcomeMessage();

        // Generate the secret number between 1 and 100 and set the maximum attempts allowed
        int secretNumber = GenerateSecretNumber(1, 100);
        int maxAttempts = 10;

        // Start the game with the generated secret number and max attempts
        PlayGame(secretNumber, maxAttempts);

        // Display a message to indicate the end of the game
        DisplayExitMessage();
    }

    // Display a welcome message to the player
    // This function introduces the game and provides basic instructions on how to play
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Higher or Lower game!");
        Console.WriteLine("Your goal is to guess the secret number between 1 and 100.");
        Console.WriteLine("You have 10 attempts, and each guess must be unique.");
        Console.WriteLine("Let's begin!");
    }

    // Generate a random secret number between the given range
    // This function takes a minimum and maximum value and returns a random number within that range
    static int GenerateSecretNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max + 1);
    }

    // Main game logic, keeps track of guesses and checks if the player wins
    // This function controls the overall gameplay, including tracking the number of guesses and whether the player wins
    static void PlayGame(int secretNumber, int maxAttempts)
    {
        // Set to store all unique guesses made by the player
        HashSet<int> uniqueGuesses = new HashSet<int>();
        int numberOfGuesses = 0;
        bool hasGuessedCorrectly = false;
        int? previousGuess = null; // Track the previous guess for giving hints

        // Loop until the player has either guessed correctly or used all attempts
        while (numberOfGuesses < maxAttempts && !hasGuessedCorrectly)
        {
            hasGuessedCorrectly = PlayerGuess(secretNumber, uniqueGuesses, ref numberOfGuesses, ref previousGuess);
        }

        // If the player did not guess correctly after using all attempts
        if (!hasGuessedCorrectly)
        {
            Console.WriteLine($"Sorry, you've used all {maxAttempts} guesses. The secret number was {secretNumber}.");
        }
    }

    // Process a player's guess, providing hints and checking for correctness
    // This function processes each guess, checks if it has been guessed before, gives hints, and evaluates the guess
    static bool PlayerGuess(int secretNumber, HashSet<int> uniqueGuesses, ref int numberOfGuesses, ref int? previousGuess)
    {
        int guess = GetPlayerGuess();
        if (guess == -1)
        {
            return false; // Invalid input, prompt again
        }

        // Check if the guess has already been made
        if (uniqueGuesses.Contains(guess))
        {
            Console.WriteLine("You've already guessed that number. Please try a different one.");
            return false;
        }

        // Add the guess to the set of unique guesses
        uniqueGuesses.Add(guess);
        numberOfGuesses++;

        // Provide hints based on the distance from the secret number
        if (previousGuess.HasValue)
        {
            int previousDistance = CalculateDistance(previousGuess.Value, secretNumber);
            int currentDistance = CalculateDistance(guess, secretNumber);

            if (currentDistance < previousDistance)
            {
                Console.WriteLine("You're getting closer!");
            }
            else if (currentDistance > previousDistance)
            {
                Console.WriteLine("You're getting farther away!");
            }
        }

        // Update the previous guess to the current guess
        previousGuess = guess;

        // Evaluate if the current guess is correct
        return EvaluateGuess(secretNumber, guess, numberOfGuesses);
    }

    // Get the player's guess, handling invalid input
    // This function prompts the player for a guess and handles any invalid input (e.g., non-numeric values)
    static int GetPlayerGuess()
    {
        Console.Write("Enter your guess: ");
        try
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number between 1 and 100.");
            return -1;
        }
    }

    // Calculate the distance between two numbers without using Math.Abs
    // This function calculates the absolute difference between two numbers by comparing them directly
    static int CalculateDistance(int a, int b)
    {
        return a > b ? a - b : b - a;
    }

    // Evaluate the player's guess against the secret number
    // This function checks if the player's guess is too high, too low, or correct and provides appropriate feedback
    static bool EvaluateGuess(int secretNumber, int guess, int numberOfGuesses)
    {
        if (guess > secretNumber)
        {
            Console.WriteLine("Too high! Try again.");
            return false;
        }
        else if (guess < secretNumber)
        {
            Console.WriteLine("Too low! Try again.");
            return false;
        }
        else
        {
            Console.WriteLine($"Congratulations! You guessed the secret number in {numberOfGuesses} tries.");
            return true;
        }
    }

    // Display a message when the game ends
    // This function thanks the player for playing and waits for them to press a key before exiting
    static void DisplayExitMessage()
    {
        Console.WriteLine("Thank you for playing the Higher or Lower game!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}








