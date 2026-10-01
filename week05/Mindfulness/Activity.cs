public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private int _timesCompleted;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _timesCompleted = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} {_timesCompleted} time(s).");
        Console.WriteLine();
        Console.WriteLine("Returning to the menu...");
        ShowSpinner(3);
    }

    public void IncrementCompletionCount()
    {
        _timesCompleted++;
    }

    public int GetDuration()
    {
        return _duration;
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}