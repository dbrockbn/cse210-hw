using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();         //needed to add Job at beginning
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;       //needed to add start year and end year
        job1.endYear = 2022;
        //job1.DisplayJobDetails();

        Job job2 = new Job();       //needed to add Job at beginning
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._startYear = 2023;
        //job2.DisplayJobDetails();

        //Resume = [job1, job2]
        Resume myResume = new Resume();     // needed to add this
        myResume._name = "Allison Rose";    //needed to add this

        myResume._jobs.Add(job1);           //needed to add this
        myResume._jobs.Add(job2);           //needed to add this

        myResume.Display();                 //needed to add this as well
    }

}
//Resume._jobs[0]._jobTitle
//Resume._jobs[1]._jobTitle