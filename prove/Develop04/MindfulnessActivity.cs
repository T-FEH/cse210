using System;
using System.Threading;

class MindfulnessActivity
{
    protected string name;
    protected string description;

    public MindfulnessActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void StartActivity(int duration)
    {
        ShowWelcomeMessage();
        Console.WriteLine("Press Enter when you are ready to start...");
        Console.ReadLine();
        ShowStartingMessage();
        Thread.Sleep(4000);
        PerformActivity(duration);
        ShowEndingMessage();
    }

    protected virtual void ShowWelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {name} activity!");
    }

    protected virtual void ShowStartingMessage()
    {
        Console.WriteLine($"Get ready for {name} activity:");
        Console.WriteLine(description);
        Console.WriteLine("Setting the duration...\n");
    }

    protected void ShowEndingMessage()
    {
        Console.WriteLine($"Great job! You have completed the {name} activity.\n");
        Thread.Sleep(3000); // Pause before finishing
    }

    protected virtual void PerformActivity(int duration)
    {

    }

    protected void ShowSpinner(int duration)
    {
        Console.Write("Processing ");

        for (int i = 0; i < duration * 2; i++)
        {
            Console.Write("/");
            Thread.Sleep(2000); 
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Move the cursor back
        }

        Console.WriteLine();
    }
}