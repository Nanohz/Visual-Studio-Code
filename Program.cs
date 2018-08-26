using System;

namespace Csharpdrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What Course are you currently on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("Ok, you are currently on :" +currentCourse);

            Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string actualPage = Console.ReadLine();
            int currentPageNum = Convert.ToInt32(actualPage);
            Console.WriteLine("Ok, this is the current page number you are on:"+actualPage);

            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'");
            bool help = true || false ;
            string helpUpdate = Convert.ToString(help);
            string helpStatus = Console.ReadLine();
            Console.WriteLine("Ok, you chose the help status of :"+helpStatus);

            Console.ReadLine();

            Console.WriteLine("Are there any positive experiences that you would like to share? If so, please share specifics");
            string sharedExp = Console.ReadLine();
            Console.WriteLine("Thank you for sharing. Here is a reciept of what you have just submitted:"+sharedExp);

            Console.ReadLine();

            Console.WriteLine("Is there any feedback that you would like to provide? Please give specifics");
            string sharedFeedback = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback. Here is a print out of your submitted feedback:"+sharedFeedback);

            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHrs = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(studyHrs);
            Console.WriteLine("Ok, here is a tally of your hours studied thus far :" + hoursStudied);

            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
















        }
    }
}
