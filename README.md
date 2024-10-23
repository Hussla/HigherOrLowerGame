# Higher or Lower Game

## Overview

This project is a simple console-based "Higher or Lower" guessing game implemented in C#. The goal of the game is for the player to guess a secret number between 1 and 100 within 10 attempts. The player must make unique guesses, and they receive hints after each guess indicating whether they are getting closer or farther away from the correct number.

## Features

- Randomly generated secret number between 1 and 100.
- Player has 10 attempts to guess the secret number.
- Each guess must be unique, and previously guessed numbers are stored.
- Hints are provided after each guess to help the player understand if they are getting closer or farther from the secret number.
- Interactive feedback provided throughout the game.

## Game Flow

1. **Welcome Message**: The game begins with a welcome message that explains the objective and rules.
2. **Player Guesses**: The player is prompted to enter their guesses, and the game ensures that each guess is unique.
3. **Hint System**: After each incorrect guess, a hint is provided to let the player know if they are getting closer or farther from the secret number compared to their previous guess.
4. **Game End**: The game ends either when the player guesses the correct number or after 10 attempts. A message is displayed to inform the player of the result.

## How to Run

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/Hussla/HigherOrLowerGame.git
   ```
2. **Navigate to the Directory**:
   ```bash
   cd higher-or-lower-game
   ```
3. **Compile and Run**:
   - Use your preferred C# compiler or IDE (e.g., Visual Studio or Visual Studio Code).
   - Run the program to start playing.

## Code Structure

The program is organized into several methods to ensure modularity and readability:

1. **`Main()`**: The entry point of the game, which handles the flow from displaying the welcome message to generating the secret number and playing the game.

2. **`DisplayWelcomeMessage()`**: Provides the player with instructions about the game.

3. **`GenerateSecretNumber(int min, int max)`**: Generates a random secret number between the specified range.

4. **`PlayGame(int secretNumber, int maxAttempts)`**: Controls the game logic, including tracking guesses and checking if the player wins.

5. **`ProcessPlayerGuess(int secretNumber, HashSet<int> uniqueGuesses, ref int numberOfGuesses, ref int? previousGuess)`**: Processes each guess, checks for uniqueness, provides hints, and evaluates the guess.

6. **`GetPlayerGuess()`**: Prompts the player for input and handles any invalid responses.

7. **`CalculateDistance(int a, int b)`**: Calculates the absolute distance between two numbers without using `Math.Abs()`.

8. **`EvaluateGuess(int secretNumber, int guess, int numberOfGuesses)`**: Evaluates whether the player's guess is too high, too low, or correct and provides feedback accordingly.

9. **`DisplayExitMessage()`**: Displays a thank-you message at the end of the game and waits for the user to press a key to exit.

## Example Gameplay

- **Welcome Message**: The game starts by displaying a welcome message and explaining the rules.
- **Player Input**: The player is prompted to enter their guess.
- **Hints**: After each guess, hints are provided:
  - "You're getting closer!"
  - "You're getting farther away!"
- **End of Game**: If the player guesses the correct number, they are congratulated. If they run out of attempts, the correct number is revealed.

## Learning Objectives

This project is designed to help practice the following skills:

- **Basic C# Programming**: Understanding variables, loops, and conditional logic.
- **Collections**: Using `HashSet<int>` to store unique guesses.
- **Function Decomposition**: Breaking down the code into smaller, reusable functions to make the game more readable and maintainable.
- **User Input Handling**: Managing user input, including error handling for non-numeric values.

## Future Improvements

- **Difficulty Levels**: Allow the player to choose different difficulty levels (e.g., increase the range of numbers or reduce the number of attempts).
- **Leaderboard**: Add a leaderboard to track the fastest guesses or the fewest attempts.
- **Graphical Interface**: Develop a graphical version of the game for a better user experience.

## Contributing

Contributions are welcome! If you have suggestions or improvements, please create an issue or submit a pull request.

## License

This project is licensed under the MIT License. Feel free to use and modify it as you wish.

## Acknowledgments

- Thanks to all who have contributed to similar C# learning projects that inspired this game.
- Special thanks to anyone who gives this game a try and provides feedback!

