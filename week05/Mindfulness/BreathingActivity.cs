public class BreathingActivity : Activity
{
    public BreathingActivity(string name = "Breathing", string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") : base(name,description)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            int remaining = (int)(endTime - DateTime.Now).TotalSeconds;
            if (remaining <= 0)
            {
                break;
            }
            Console.Write("Breathe in...");
            ShowCountDown(Math.Min(5,remaining));
            Console.WriteLine();

            Console.Write("Breathe out...");
            ShowCountDown(Math.Min(5,remaining));
            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
    }
}