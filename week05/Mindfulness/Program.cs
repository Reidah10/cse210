// I added a counter for the amount of times the user has completed each activity as well as made sure that the user cannot recieve the same prompts until they've all ben exhausted in the Reflection and Listing activities using a new class called PromptManager.

using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Activities Program!");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an activity (1-4): ");

            string choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    breathing.Run();
                    break;
                case "2":
                    reflection.Run();
                    break;
                case "3":
                    listing.Run();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    ShowCountdown(2);
                    break;
            }
        }

        Console.WriteLine("Thank you for using the Mindfulness Activities program. Goodbye!");
    }

    static void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}