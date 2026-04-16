using System.Runtime;
using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name,description,points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Bonus! you earned {_bonus} points.");
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        if (_amountCompleted == _target)
        {
            return $"{status} {_shortName} ({_description}) -- Goal Completed";            
        }
        else
        {
            return $"{status} {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target} times";            
        }
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}";
    }
}