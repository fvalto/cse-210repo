using System;

class Program
{
    static void Main(string[] args)
    {
        int target;
        int guess;
        int tries = 0;
        // Console.Write("What is the magic number?: ");
        // target = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        target = randomGenerator.Next(0, 101);

        do 
        {
            Console.Write("What is your guess?: ");
            tries++;
            guess = int.Parse(Console.ReadLine());
            if (target > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (target < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {tries} tries.");
            }
        } while (target != guess);
    }
}