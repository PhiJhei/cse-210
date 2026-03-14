using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._startYear = 2022;
        job1._endYear = 2025;
        job1._jobTitle = "Software Engineer";
        job1._company = "Valve";

        Job job2 = new Job();
        job2._startYear = 2019;
        job2._endYear = 2021;
        job2._jobTitle = "Customer Service";
        job2._company = "Meta";

        Resume resume = new Resume();
        resume._name = "Jhei Salvatierra";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();
    }
}