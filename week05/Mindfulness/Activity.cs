public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
        Console.WriteLine();
    }
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
        Thread.Sleep(250);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character

        Thread.Sleep(250);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("\\"); // Replace it with the - character

        Thread.Sleep(250);
        
        Console.Write("\b \b"); // Erase the + character
        Console.Write("|"); // Replace it with the - character

        Thread.Sleep(250);
        
        Console.Write("\b \b"); // Erase the + character
        Console.Write("/"); // Replace it with the - character
        }

        Console.Write("\b \b"); // Erase the + character
        Console.Write(""); // Replace it with the - character
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}