using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        int total = 0;
        double average = 0;
        do
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        while (number != 0);
        for (int i = 0; i < numbers.Count; i++)
        {
            total += numbers[i];
        }
        if (numbers.Count > 0)
        {
            average = (double)total / numbers.Count;
        }
        Console.WriteLine($"The sum of the numbers is: {total}");
        Console.WriteLine($"The average of the numbers is: {average}");
    }
}