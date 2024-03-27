using System;

class ReflectionActivity : MindfulnessActivity
{
    public ReflectionActivity() : base("Reflection", "Reflect on times of strength and perserverence.")
    {
    }

    protected override void ShowWelcomeMessage()
    {
        base.ShowWelcomeMessage();
        Console.WriteLine("Reflect on your past experiences of strength and perseverence.");
    }

    protected override void PerformActivity(int duration)
    {
        string[] prompts = {
            "What motivates you in life to perseverse despite your difficulties.",
            "Think of a time when you almost brokedown but you managed to overcome it.",
            "Reflect on a time that you were strengthened of the Lord.",
            "Reflect on a time that you were physically and mentally strong."
        };

        Console.WriteLine("Let's begin:");

        for (int i = 0; i < duration; i++)
        {
            string prompt = prompts[new Random().Next(prompts.Length)];
            Console.WriteLine(prompt); // Display the prompt
            Thread.Sleep(3000); // Pause for 3 seconds
            AskQuestions();
        }
    }

    private void AskQuestions()
    {
        string[] questions = {
            "What is your biggest motivation in life?",
            "Where do you see yourself in the next 3 years?",
            "Do you love your job?",
            "What is your greatest strength?",
            "What excites you most about this course?",
            "What is your favourite bible passage?",
            "How did you get to this point?",
            "How has the gospel blessed your life?",
        };

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(4000); // Pause for 4 seconds 
        }
    }
}