using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade?");
        int grade = int.Parse(Console.ReadLine());
        
        Console.WriteLine("you endered: " + grade + " as your grade" + ": this correlates to a letter grade of: " + GetLetterGrade(grade));
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed!");
        }
    }

    static string GetLetterGrade(int grade)
    {
        if (grade >= 90)
        {
            return "A";
        }
        else if (grade >= 80)
        {
            return "B";
        }
        else if (grade >= 70)
        {
            return "C";
        }
        else if (grade >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}

