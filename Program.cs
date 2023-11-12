using System;


namespace Daily_Student_Report
{
    internal class Program
    {
        static void Main()
        {
            //Greetings
            Console.WriteLine("Academy of Learning College");
            Console.WriteLine("Student Daily Report");
            
            //Asking for name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            
            //Asking for Course
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            
            //Asking for page number
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
           
            //Asking Student if help is necessary
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp);
            
            //Asking for Student's positive experience
            Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics");
            string positiveExperience = Console.ReadLine();
            
            //Asking for Feedback
            Console.WriteLine("Is there any feedback you would like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            
            //Asking how many hours the student studied
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            
            //Thank you message
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
