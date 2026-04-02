using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new("Samuel Bennett", "Multiplication");
        Console.WriteLine(a.GetSummary());
        Console.WriteLine();

        MathAssignment m = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(m.GetSummary());
        Console.WriteLine(m.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment w = new WritingAssignment("Mary Waters","European History", "The Causes of World War II");
        Console.WriteLine(w.GetSummary());
        Console.WriteLine(w.GetWritingInformation());
    }
}