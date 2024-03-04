using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeP = Console.ReadLine();
        int number = int.Parse(gradeP);
        string letter = "";

        if (number >= 90)
        {
            letter = "A";
            
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (number >= 70)
        {
            Console.Write("Congratulations, You passed the course.");
        }
        else
        {
            Console.Write("I'm sorry, You failed the course... Try harder next time.");
        }
    }
}