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

    //Prompt the user for a difficulty level before they are prompted to guess the number.

    Console.WriteLine("(1)easy  (2)medium  (3)hard  (4)cheater");
    Console.WriteLine();
    Console.Write("Choose your difficulty:");

    int attemptCount = 8;

    string userDifficulty = Console.ReadLine().ToLower(); 
    int parsedDifficulty = int.Parse(userDifficulty);

    //make sure difficulty selection is valid
    if(parsedDifficulty > 0 && parsedDifficulty < 5)
    {
        // Easy gives user eight guesses, Medium gives user six guesses, Hard gives user four guesses.
        // Cheater difficulty gives user 9001 guesses lol
        attemptCount = parsedDifficulty == 1 ? 8 : 
        (parsedDifficulty == 2 ? 6 :
        (parsedDifficulty == 3 ? 8 : 9001));

        //declare secret number and the users attempt count
        int secretNumber = new Random().Next(1, 100);
        
        //game runs until 0 attempts remaining
        while (attemptCount > 0)

        {
            //Primary Question
            Console.WriteLine();
            Console.WriteLine("Guess the secret number...");
            Console.WriteLine("(between 1 and 100)");
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
            if (parsedInput > 0 && parsedInput < 101) 
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
                
                if(parsedInput > secretNumber){
                    Console.WriteLine("(pssst... try guessing LOWER!");
                }

                else{
                    Console.WriteLine("   pssst... try guessing HIGHER!");
                }

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
}
