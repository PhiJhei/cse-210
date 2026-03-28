using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new("John",3,16);
        Scripture scripture = new(reference, "For God so loved the world, that He gave his only begotten son, that whosoever beliveth in him shall not perish but have everlasting life.");
        
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            string input = Console.ReadLine();

            if(input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}