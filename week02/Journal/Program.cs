// I added a sixth function to let someone search their journal entries of a loaded entry by date.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine("Please choose one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Search by date (M/D/YYYY) ");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();


            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");

                string response = Console.ReadLine();
                Entry entry = new Entry(DateTime.Now.ToShortDateString(), prompt, response);

                journal.AddEntry(entry);
            }

            if (choice == "2")
            {
                journal.DisplayAll();  
            }

            if (choice == "3")
            {
                Console.WriteLine("What do you want to name your file? ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }

            if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }

            if (choice == "5")
            {
                Console.Write("What date would you like to see? ");
                string date = Console.ReadLine();

                journal.DisplayByDate(date);
            }
        }
    }
}