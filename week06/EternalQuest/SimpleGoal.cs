using System.Drawing;

public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, string description, int points) : base(name,description,points)
    {
        isComplete = false;
    }
    public override void RecordEvent()
    {
        isComplete = true;
        Console.WriteLine($"You earned {_points} points!");
    }
    public override bool IsComplete()
    {
        return isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{isComplete}";
    }
    public override string GetDetailsString()
    {
        return "";
    }
}