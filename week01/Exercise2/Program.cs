using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        int lastDigit = grade % 10;
        string sign = "";
        string letter = "";
        string modifier = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        if (grade < 60)
        {
            letter = "F";
        }
        if (letter == "A")
        {
            modifier = "an";
        }
        else
        {
            modifier = "a";
        }
        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        if (lastDigit <= 3 && letter != "F")
        {
            sign = "-";
        }
        Console.WriteLine($"You have {modifier} {letter}{sign} in this class.");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class. Keep trying. You can do it!");
        }
    }
}