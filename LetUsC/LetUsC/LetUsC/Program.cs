using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetUsC.Chapter_01;

namespace LetUsC
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Hello World!");
            // Chapter_01.Gross gross = new Gross();
            //gross.FindGrossSalaryofUser();
            Chapter_01.DistanceBetweenTwoCitiesInDiffrentFormats 
                distanceBetweenTwoCities = new DistanceBetweenTwoCitiesInDiffrentFormats();
            distanceBetweenTwoCities.DistanceBetweenTwoCities();

            Console.WriteLine("***************************************************************************************");
            Chapter_01.marks_obtained_by marks_Obtained_By = new marks_obtained_by();
            marks_Obtained_By.MarksObtainedByAStudentInFiveDifferentSubjects();




            Console.ReadKey();

            

        }

        
    }
}
