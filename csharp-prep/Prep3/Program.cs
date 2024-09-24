using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess what it is?");
        int guess = int.Parse(Console.ReadLine());
        while (guess != number)
        {
            Console.WriteLine("You guessed incorrectly. guess again!");
            guess = int.Parse(Console.ReadLine());
        if (guess > number)    
            {
                Console.WriteLine("Guess lower!");
            }
            else
            {
                Console.WriteLine("Guess higher!");
            }
            }
}
}