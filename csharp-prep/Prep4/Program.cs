using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

    Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    int number = 0;
        do 
        {
            int i = 0;
            numbers.Add(number);
            
            if (i != 0); 
            {
                Console.WriteLine("Enter another number:");
            }
            number = int.Parse(Console.ReadLine());
        }
        while (number != 0);
    
    Console.WriteLine($"Your total is: {numbers.Sum()}");
    Console.WriteLine($"Your average is: {numbers.Average()}");
    Console.WriteLine($"Your Max/Largest is: {numbers.Max()}");


    }
}