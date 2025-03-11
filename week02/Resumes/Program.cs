using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Apple";
        job1._startYear = 2000;
        job1._endYear = 2005;

        Job job2 = new Job();
        job2._jobTitle = "Backend Developer";
        job2._company = "Netflix";
        job2._startYear = 2003;
        job2._endYear = 2010;

        Resume resume = new Resume();
        resume._name = "Alan Turing";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        
        resume.Display();
    }
    
}