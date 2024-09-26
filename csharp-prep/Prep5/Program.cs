using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int usernum = PromptUserNumber();
        SquareNumber(usernum);
        DisplayResult(usernum, username);
    }

    static void DisplayWelcome () 
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName () 
    {
        Console.WriteLine("What what you like your username to be ?:");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber ()
    {

        Console.WriteLine("What number would you like squared today?:");
        int usernumber = int.Parse(Console.ReadLine());
        return usernumber;
    }

    static int SquareNumber(int usernumber)
    {
        int numbersquared = (int)Math.Pow(usernumber, 2); 
        return numbersquared;
    }

    static void DisplayResult(int number, string username)
    {
        Console.WriteLine($"{username}, your number squared is {number}");
    }

}