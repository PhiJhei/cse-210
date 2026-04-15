using System.Runtime.InteropServices;

public abstract class Activity
{
    private string _date;
    private int _lengthInMinutes;
    public Activity(string date,int minutes)
    {
        _date = date;
        _lengthInMinutes = minutes;
    }
    public string GetDate()
    {
        return _date;
    }
    public int GetMinutes()
    {
        return _lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"{GetDate()} {GetType().Name} ({GetMinutes()} min)- " +
                $"Distance {GetDistance():0.0} miles, " +
                $"Speed {GetSpeed():0.0} mph, " +
                $"Pace {GetPace():0.0} min per mile";
    }
}