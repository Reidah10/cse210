public class ReflectionActivity : Activity
{
    private PromptManager _promptManager;

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        List<string> prompts = new List<string>
        {
            "Think of a time when you overcame a significant challenge.",
            "Recall a moment when you helped someone in need.",
            "Reflect on a personal achievement that made you proud.",
            "Consider a time when you learned an important lesson from failure.",
            "Think about a situation where you demonstrated courage."
        };
        _promptManager = new PromptManager(prompts);
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        ShowSpinner(3);
        int elapsed = 0;

        while (elapsed < duration)
        {
            string prompt = _promptManager.GetNextPrompt();

            Console.WriteLine();
            Console.WriteLine(prompt);
            Console.WriteLine();

            ShowSpinner(5);

            elapsed += 5;
        }

        IncrementCompletionCount();
        DisplayEndingMessage();
    }
}
