using System;

class ListingActivity : MindfulnessActivity
{
    public ListingActivity() : base("Listing", "List as many positive things as you can in a certain area.")
    {
    }

    protected override void ShowWelcomeMessage()
    {
        base.ShowWelcomeMessage();
        Console.WriteLine("List positive things to reflect on your strengths and gratitude.");
    }

    protected override void PerformActivity(int duration)
    {
        string[] prompts = {
            "What are your biggest feats?",
            "What is your biggest motivation?",
            "How has God blessed your life?",
            "How have you been saved you from danger?",
            "What is your biggest achievement? "
        };

        Console.WriteLine("Let's begin:");

        for (int i = 0; i < duration; i++)
        {
            string prompt = prompts[new Random().Next(prompts.Length)];
            Console.WriteLine(prompt);
            Thread.Sleep(8000);
            ListItems();
        }
    }

    private void ListItems()
    {
        Console.WriteLine("Enter an item (or type 'done' to finish): ");
        int count = 0;
        while (true)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
                break;
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
    }
}