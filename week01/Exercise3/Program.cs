using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magic = randomNumber.Next(1,101);
        int i = 0;
        int guess = 0;

        while (guess != magic)
        {
            i++;
            Console.WriteLine("What is the number?");
            guess = int.Parse(Console.ReadLine());

            if (guess == magic)
            {
                Console.WriteLine("Correct!");
                Console.WriteLine($"{i} attempts were made");
            }
            else if (guess < magic)
            {
                Console.WriteLine("higher");
            }
            else if (guess > magic)
            {
                Console.WriteLine("lower");
            }   
        }

    }
}