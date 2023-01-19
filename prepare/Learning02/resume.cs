using System;           //needed to add this

public class Resume
{
      
    //public string _name= "";

    public string _name;    

    //Make sure to initialize your list to a new list before you use it ..Yes I need to remember this
    //public list _jobs= list<Job>
    public List<Job> _jobs = new List<Job>();

    public void Display ()        //needed this here not down later
    {

        Console.Writeline($"Name: {_name}");         //this is right not later like I had
        Console.Wrtieline("Jobs:");

        foreach (Job job in _jobs)   //I forgot to add a loop
        {
            //This calls the Display method on each job
            job.Display();
        }
    }
}
 //public void DisplayResume() 
  //Console.WriteLine($"{_name}, {_jobs}");
        
    
    