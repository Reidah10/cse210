using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(new DateTime(2026, 10, 12), 30, 3.0);
        Cycling cycling = new Cycling(new DateTime(2026, 10, 12), 30, 12.0);
        Swimming swimming = new Swimming(new DateTime(2026, 10, 12), 30, 40);

        List<Activity> activities = new List<Activity>
        {
            running, cycling, swimming
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}