using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();
        int stop = 0;
        int guess = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (guess != stop)
        {
            Console.Write("Enter number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess != stop)
            {
                numbersList.Add(guess);
            }
        }

        decimal sum = numbersList.Sum();
        Console.WriteLine($"The sum is: {sum}");

        Console.Write("The average is: ");
        decimal avg = sum / numbersList.Count();
        Console.WriteLine(avg);

        int largest = numbersList.Max();
        Console.WriteLine($"The largest number is: {largest}");
    }
}