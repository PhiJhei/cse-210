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
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }
    public override bool IsComplete()
    {
        return isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}";
    }
    public override string GetDetailsString()
    {
        string status = isComplete ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})";
    }
}