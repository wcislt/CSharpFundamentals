using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer speaker = new SpeechSynthesizer();

            string[] sayings = new string[5];
            sayings[0] = "Aurora borealis?";
            sayings[1] = "At this time of year.";
            sayings[2] = "At this time of day.";
            sayings[3] = "In this part of the country.";
            sayings[4] = "Localized entirely within your kitchen?";

            

            /*foreach (string saying in sayings)
            {
                Console.WriteLine(saying);
                speaker.Speak(saying);
            }*/

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(87.3f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
        }
    }
}
