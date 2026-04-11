// Showing creativity: 
// No duplicate questions for Reflecting Activity prompts

using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int select = 0;

        while (select != 4)
        {
        Console.WriteLine("Menu options: ");
        Console.WriteLine("  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit");
        Console.Write("Select a choice from the menu: ");
            select = int.Parse(Console.ReadLine());
            if (select == 1)
                {
                    BreathingActivity a = new();
                    a.Run();
                }
            else if (select == 2)
                {
                    ReflectingActivity a = new();
                    a.Run();

                }
            else if (select == 3)
                {
                    ListingActivity a = new();
                    a.Run();
                }
            Console.Clear();
        }
    }
}