using System;

Main();

void Main()
{

Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("              Let's play a game :)             ");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine();

GuessANumber();

}

static void GuessANumber()
{

    int secretNumber = 42;
    int attemptCount = 4;
    
    Console.WriteLine();
    Console.WriteLine("Guess the secret number...");
    Console.WriteLine("(between 1 and 100)");
    Console.WriteLine();
    Console.Write("your guess:");

    string userInput = Console.ReadLine().ToLower(); // Read the user's input
    int parsedInput = int.Parse(userInput);

    if (parsedInput > 0 && parsedInput < 101) // Validate and parse the user's choice
    {

        if (parsedInput == secretNumber) // Validate and parse the user's choice
        {
            Console.WriteLine($"CONGRATULATIONS! You guessed the secret number! ({userInput}) ");
        }

        else
        {
        attemptCount--;
        Console.WriteLine();
        Console.WriteLine($@"Sorry, {userInput} is incorrect.
        You have {attemptCount} attempts remaining.");
        GuessANumber();
        }
    }

    else if(userInput.ToLower() == "quit")
    {
       return;
    }

    else
    {
        Console.WriteLine();
        Console.WriteLine("Please enter a valid response or 'QUIT' to end."); // Display an error message for an invalid choice
        GuessANumber();
    }

}
