using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2017;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2020;
        job2._endYear = 2021;

        Resume me = new Resume();
        me._name = "Nicholas Nelson";

        me._jobs.Add(job1);
        me._jobs.Add(job2);

        me.Display();

    }
}