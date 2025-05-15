using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Amazon";
        job1._jobTitle = "CEO";
        job1._startYear = 2004;
        job1._endYear = 2030;

        Job job2 = new Job();
        job2._company = " Microcenter";
        job2._jobTitle = "Web Developer";
        job2._startYear = 1998;
        job2._endYear = 2004;

        Resume resume = new Resume();
        resume._jobList.Add(job1);
        resume._jobList.Add(job2);

        resume.DisplayDetails();
    }
}