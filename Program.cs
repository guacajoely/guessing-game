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

    //declare secret number and the users attempt count
    int secretNumber = new Random().Next(1, 10);
    int attemptCount = 4;
    
    //game runs until 0 attempts remaining
    while (attemptCount > 0)

    {
        //initial question
        Console.WriteLine();
        Console.WriteLine("Guess the secret number...");
        Console.WriteLine("(between 1 and 10)");
        Console.WriteLine();
        Console.Write($"your guess:");

        //grab user input
        string userInput = Console.ReadLine().ToLower(); 

        //quit returns out of while loop
        if(userInput == "quit")
        {
            return;
        }

        //parse user input into integer
        int parsedInput = int.Parse(userInput);

        //check that guess is valid
        if (parsedInput > 0 && parsedInput < 11) 
        {
            //If user guesses correctly
            if (parsedInput == secretNumber) 
            {
                Console.WriteLine($"CONGRATULATIONS! You guessed the secret number! ({userInput}) ");
                break;
            }

            //Otherwise, user is wrong.
            else
            {
            attemptCount--;
            Console.WriteLine();
            Console.WriteLine($"{userInput} is incorrect. You have {attemptCount} attempts remaining.");

            //Inform user of no attempts remaining
            if(attemptCount == 0){
                 Console.WriteLine($"Sorry! You are out of attempts. The secret number was... {secretNumber}");
            }
            }
        }

        //invalid response returns messsage and quit instructions
        else
        {
            Console.WriteLine();
            Console.WriteLine("Please enter a valid response or 'QUIT' to end.");
        }
    }

    //once game ending prompts play again question
    Console.WriteLine();
    Console.Write($"Play Again? (Y/N):");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"Play Again? (Y/N):");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        GuessANumber();
    }

    else
    {
        return;
    }
}
