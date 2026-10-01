public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by helping you focus on your breathing. Clear your mind and focus on your breath.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine();
            elapsed += 4;

            if (elapsed >= duration) break;

            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
            Console.WriteLine();
            elapsed += 6;
        }
        IncrementCompletionCount();
        DisplayEndingMessage();
    }
}