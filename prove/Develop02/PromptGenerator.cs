using System;

class PromptGenerator
{
    public List<string> prompts;

    public PromptGenerator()
    {
        // Initialize with some example prompts
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today? ",
            "What was the best part of my day? ",
            "What is your favorite food? ",
            "If I had one thing I could do over today, what would it be? ",
            "When do you intend settling down? ",
            "What was the strongest emotion I felt today? ",
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}