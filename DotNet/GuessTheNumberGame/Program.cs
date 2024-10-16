const int MaximumNumber = 20;
const int NumberOfAttempts = 3;

Console.WriteLine("Welcome to the Guess the Number game!");

int correct = Random.Shared.Next(1, MaximumNumber + 1);
// Console.WriteLine(correct);

for (int i = 0; i < NumberOfAttempts; i++)
{
    int guess = ReadPlayerGuess();

    if (guess < correct)
    {
        Console.WriteLine("Correct number is larger!");
    }
    else if (guess > correct)
    {
        Console.WriteLine("Correct number is smaller!");
    }
    else
    {
        Console.WriteLine("Good going! You guessed the number correctly!");
        AskPlayerNameForHighScoreList(i);
        break;
    }
}

Console.WriteLine("Game ends.");
DisplayHighScoreList();

int ReadPlayerGuess()
{
    while (true)
    {
        try
        {
            Console.WriteLine($"Please enter your guess (1-{MaximumNumber}):");
            string input = Console.ReadLine() ?? "0";
            int guess = int.Parse(input);

            if (guess < 1 || guess > MaximumNumber)
            {
                Console.WriteLine($"The guess must be between 1 and {MaximumNumber}.");
            }
            else
            {
                return guess;
            }
        }
        catch
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }
}

void AskPlayerNameForHighScoreList(int guessRound)
{
    Console.WriteLine("Please enter your name for the high-score list:");
    string name = Console.ReadLine() ?? "0";
    int numberOfGuesses = guessRound + 1;
    string highScore = numberOfGuesses + "," + name + "\r\n";
    File.AppendAllText("Highscores.dat", highScore);
}

void DisplayHighScoreList()
{
    // high-score list display
    Console.WriteLine("High score list:");
    string[] lines = File.ReadAllLines("Highscores.dat");
    Array.Sort(lines);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
