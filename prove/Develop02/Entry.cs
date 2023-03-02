public class Entry
{
    string _date; // _ helps you understand that it belongs to a class


    string _prompt;

    string _response;

   
    PromptGenerator _promptGenerator = new PromptGenerator();  //class promptgenerator //instantiating a class
    public Entry(string response){     // constructor can accept 
    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString(); //use this to set date attribute to current date and use promptgenerator and set that equal
    ///set response when user enters 


    }
    

}
//date,  prompt, reponse = member variables or attributes 
