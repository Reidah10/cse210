using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            Console.WriteLine("I have a magic number! Can you guess it?");
            int guess = 0;
            int numberOfGuesses = 0;
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                numberOfGuesses++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower.");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher.");
                }
            }
            while (guess != magicNumber);
            Console.WriteLine($"You guessed it! Congratulations! It took you {numberOfGuesses} guesses to find it.");
            Console.Write("Would you like to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }
        while (playAgain.ToLower() == "yes"); 
    }
}