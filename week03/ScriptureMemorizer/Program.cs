//I added a menu that allows the user to choose whether they want to use the default scripture or one that they choose. Each file contains one scripture, so the user needs a file of their desired scripture, but it works.

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Scripture Memorizer Tool!");
        Console.WriteLine();
        Console.WriteLine("1. Use a scripture file");
        Console.WriteLine("2. Use the default scripture");
        Console.WriteLine("3. Quit");
        Console.WriteLine();
        Console.Write("Which option would you like to use? ");

        string choice = Console.ReadLine();

        Reference reference;
        Scripture scripture;

        if (choice == "3")
        {
            return;
        }
        else if (choice == "2")
        {
            reference = new Reference("Proverbs", 3, 5);
            scripture = new Scripture(
                reference,
                "Trust in the Lord with all thine heart; and lean not unto your own understanding."
            );
        }
        else if (choice == "1")
        {
            string[] files = Directory.GetFiles("scriptures");

            Console.WriteLine();
            Console.WriteLine("Available scriptures:");
            
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Path.GetFileName(files[i])}");
            }
            
            Console.Write("Choose a scripture: ");
            int fileChoice = int.Parse(Console.ReadLine());
            
            string[] lines = File.ReadAllLines(files[fileChoice - 1]);

            string[] referenceParts = lines[0].Split('|');

            if (referenceParts.Length == 3)
                {
                    reference = new Reference(referenceParts[0], int.Parse(referenceParts[1]), int.Parse(referenceParts[2]));
                }
                else
                {
                    reference = new Reference(referenceParts[0], int.Parse(referenceParts[1]), int.Parse(referenceParts[2]), int.Parse(referenceParts[3]));
                }
                scripture = new Scripture(
                    reference,
                    lines[1]
                );
            }
            else
            {
                Console.WriteLine("Invalid Selection");
                return;
            }

            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                Console.WriteLine("Press Enter to continue or 'quit' to stop.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
                scripture.HideRandomWords();
            }

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
            }
    }
}