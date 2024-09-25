using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
    int number; 
    Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do 
        {
            numbers.Add(number);
            Console.WriteLine("Enter another number:");
            number = int.Parse(Console.ReadLine());
        }
        while (number != 0);
    }
}