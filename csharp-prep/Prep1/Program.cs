using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your firstname? ");
        string firstname = Console.ReadLine();
        Console.Write("What is your lastname? ");
        string lastname = Console.ReadLine();
        Console.WriteLine();
        Console.Write($"Your name is {lastname}, {firstname} {lastname}.");
    }
}