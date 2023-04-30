using System;

class Program
{
    static void Main(string[] args)
    {   

        string response;

        do
        {
            /*Console.Write("What is the magic number? ");
            int magicNum = int.Parse(Console.ReadLine());*/

            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1,101);

            int guess;

            int numGuesses = 0;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                numGuesses ++;

                if (guess < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it! ");
                }
            } while (guess < magicNum || guess > magicNum);
            
            Console.WriteLine($"You made {numGuesses} guesses.");

            Console.Write("Do you want to play again? (yes/no) ");
            response = Console.ReadLine();
            
        } while (response == "yes");
    }
}