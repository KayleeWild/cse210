using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            _company = "Microsoft",
            _jobTitle = "Software Engineer",
            _startYear = 2019,
            _endYear = 2022
        };
        job1.DisplayJob();
        Job job2 = new Job
        {
            _company = "Apple",
            _jobTitle = "Manager",
            _startYear = 2022,
            _endYear = 2023
        };
        job2.DisplayJob();
        Resume myResume = new();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._name = "Allison Rose";
        myResume.DisplayResume();
    }
}