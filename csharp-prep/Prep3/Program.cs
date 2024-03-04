using System;

class Program
{
    static void Main(string[] args)
    {

        // For Task 1 and 2
        //Console.Write("What is the magic number? ");
        //string num = Console.ReadLine();
        //int numGuess = int.Parse(num);
        int guess = -1;

        // For Task 3
        Random randomGenerator = new Random();
        int numGuess = randomGenerator.Next(1, 101);

        while (guess != numGuess)
        {
            Console.Write("What is your guess? ");
            string gNum = Console.ReadLine();
            guess = int.Parse(gNum);

            if (guess > numGuess)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < numGuess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.Write("You guessed it!");
            }
        }
        
    }
}