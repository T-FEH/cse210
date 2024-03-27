using System;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing", "Relax by focusing on your breathing.")
    {
    }

    protected override void ShowWelcomeMessage()
    {
        base.ShowWelcomeMessage();
        Console.WriteLine("Relax by focusing on your breathing.");
    }

    protected override void PerformActivity(int duration)
    {
        Console.WriteLine("Let's begin:");

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(5000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(5000);
        }
    }
}