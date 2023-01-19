 // A code template for the category of things known as JOb. The
    // responsibility of Job is to hold and display job information.
    public class Job
    {
        // The C# convention is to start member variables with an underscore _
        public string _company= "";
        public string _jobTitle = "";
        public int _startYear = "";
        public int _endYear = "";

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Job()
        {
        }

        // A method that displays the jobs details begginning and end 
        // such as <start year, end year>.
        public void DisplayJobDetails()
        {
            Console.WriteLine($"{_startYear}, {_endYear}");
        }

        
        }
    }
    