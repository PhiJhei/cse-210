using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // constructors
        Journal journal = new();
        PromptGenerator prompt = new();

        // loop until selecting quit
        int select = 0;
        while (select != 5)
        {
        Console.WriteLine("Select an option: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        select = int.Parse(Console.ReadLine());
            
            if (select == 1) // WRITE
            {
                // random writing prompt
                string promptText = prompt.GetRandomPrompt();
                Console.WriteLine(promptText);
                // write entry
                Console.Write("> ");
                string input = Console.ReadLine();
                // assign values to Entry variables
                Entry entry = new Entry();
                entry._date = "3/18/2026";
                entry._promptText = promptText;
                entry._entryText = input;
                // add entry
                journal.AddEntry(entry);
            }
            else if (select == 2) // DISPLAY
            {
                journal.DisplayAll();
            }
            else if (select == 3) // SAVE
            {
                Console.WriteLine("Name your file: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (select == 4) // LOAD
            {
                Console.WriteLine("Name of file to open: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
        }
    }
}