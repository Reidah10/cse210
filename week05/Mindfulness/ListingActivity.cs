public class ListingActivity : Activity
{
    private PromptManager _promptManager;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _promptManager = new PromptManager(prompts);
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        string prompt = _promptManager.GetNextPrompt();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can for the following prompt: ");
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();

        Console.WriteLine($"You have a few seconds to think.");
        ShowCountdown(5);

        Console.WriteLine();
        Console.WriteLine($"Start listing items! You have {duration} seconds. Press Enter after each item.");

        int count = 0;
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("> ");

            while (!Console.KeyAvailable && (DateTime.Now - startTime).TotalSeconds < duration)
            {
                Thread.Sleep(100);
            }

            if ((DateTime.Now - startTime).TotalSeconds >= duration)
            {
                break;
            }

            Console.ReadLine();
            count++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");

        IncrementCompletionCount();
        DisplayEndingMessage();
    }


}