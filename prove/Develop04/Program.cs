using System;
 class Program
{
    static void Main(string[] args)
    {
        // Introducing the program
        Console.WriteLine("Welcome to the Mindfulness Program!");
        
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                MindfulnessActivity activity = new BreathingActivity();
                GetUserDurationAndStartActivity(activity);
            }
            else if (choice == "2")
            {
                MindfulnessActivity activity = new ReflectionActivity();
                GetUserDurationAndStartActivity(activity);
            }
            else if (choice == "3")
            {
                MindfulnessActivity activity = new ListingActivity();
                GetUserDurationAndStartActivity(activity);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid response. Please enter a number between 1-4.");
            }
        }
    }

    static void GetUserDurationAndStartActivity(MindfulnessActivity activity)
    {
        Console.Write("Enter the duration in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            activity.StartActivity(duration);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}