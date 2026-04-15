using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running ("14 April 2026",30,3.7));
        activities.Add(new Cycling ("14 April 2026",30,7.5));
        activities.Add(new Swimming("14 April 2026",30,40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}