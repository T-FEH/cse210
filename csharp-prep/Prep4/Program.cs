using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int Number = -1;
        while (Number != 0)
        {
            Console.Write("Enter a number, type 0 to exit: ");
            
            string input = Console.ReadLine();
            Number = int.Parse(input);
            
            if (Number != 0)
            {
                numbers.Add(Number);
            }
        }

        // Task 1
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The sum is: {total}");

        // Task 2
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Task 3
        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        Console.WriteLine($"The largest number is: {maximum}");
    }
}