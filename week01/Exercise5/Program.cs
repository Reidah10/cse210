using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName("");
        int userNumber = PromptUserNumber(0);
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName(string name)
    {
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(int number)
    {
        Console.Write("Please enter your favorite number: ");
        number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Welcome to the program, {name}! The square of your favorite number is {squaredNumber}.");
    }
}