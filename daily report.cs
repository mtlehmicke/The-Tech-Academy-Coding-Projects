using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string whatCourse;
            string pageNumber;
            bool needHelp;
            string positiveExperiences;
            string courseFeedback;
            string studyHours;

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            whatCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            pageNumber = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            needHelp = bool.Parse(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            courseFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            studyHours = Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!") ;
        }
    }
}
