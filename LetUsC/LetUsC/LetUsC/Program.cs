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
            lines();
            //Console.WriteLine("Hello World!");
            // Chapter_01.Gross gross = new Gross();
            //gross.FindGrossSalaryofUser();
            //Chapter_01.DistanceBetweenTwoCitiesInDiffrentFormats
            //    distanceBetweenTwoCities = new DistanceBetweenTwoCitiesInDiffrentFormats();
            //distanceBetweenTwoCities.DistanceBetweenTwoCities();
            //lines();
            //Chapter_01.marks_obtained_by marks_Obtained_By = new marks_obtained_by();
            //marks_Obtained_By.MarksObtainedByAStudentInFiveDifferentSubjects();
            //lines();
            Chapter_01.Temperature_of_a_city temperature_Conversion = new Temperature_of_a_city();
            temperature_Conversion.ConvertTempature();

            //lines();
            //Chapter_01.Rectangle_Circle rectangle_Circle = new Rectangle_Circle();
            //rectangle_Circle.RectangleOrCircle();

            //Chapter_01.InterchangeTheContents interchangeTheContents = new InterchangeTheContents();
            //interchangeTheContents.InterchangeTheContentsOfTwoNumbers();





            lines();
            Console.ReadKey();



        }

        private static void lines()
        {
            Console.WriteLine("***************************************************************************************");
        }

    }
}
