using System;
// Added an if else condition statement for checklist goals to display different strings appropriate to their completion progress
class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();
        gm.Start();
    }
}