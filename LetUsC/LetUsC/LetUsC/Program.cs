using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetUsC.Chapter_01;
using LetUsC.Chapter_02;

namespace LetUsC
{
    class Program
    {
        static void Main(string[] args)
        {
            lines();
            //Chapater1();
            Chapater2();

            lines();
            Console.ReadKey();



        }

        private static void Chapater2()
        {
            Chapter_02.ProfitAndLoss Chapter2 = new ProfitAndLoss();
            Chapter2.ProfitAndLossMadebyUser();
        }

        private static void Chapater1()
        {
            //Console.WriteLine("Hello World!");
            // Chapter_01.Gross gross = new Gross();
            //gross.FindGrossSalaryofUser();
            //Chapter_01.DistanceBetweenTwoCitiesInDiffrentFormats
            //distanceBetweenTwoCities = new DistanceBetweenTwoCitiesInDiffrentFormats();
            //distanceBetweenTwoCities.DistanceBetweenTwoCities();
            //Chapter_01.marks_obtained_by marks_Obtained_By = new marks_obtained_by();
            //marks_Obtained_By.MarksObtainedByAStudentInFiveDifferentSubjects();
            //Chapter_01.Temperature_of_a_city temperature_Conversion = new Temperature_of_a_city();
            // temperature_Conversion.ConvertTempature();
            //Chapter_01.Rectangle_Circle rectangle_Circle = new Rectangle_Circle();
            //rectangle_Circle.RectangleOrCircle();
            //Chapter_01.InterchangeTheContents interchangeTheContents = new InterchangeTheContents();
            //interchangeTheContents.InterchangeTheContentsOfTwoNumbers();
            SumOfFiveDigitNumber ExtensionMethod = new SumOfFiveDigitNumber();
            //sumOfFiveDigitNumber.Sumoffivedigits();
            ExtensionMethod.Test();
            //ExtensionMethod.ReverseOfFiveDigitNumber();
            //ExtensionMethod.SumOfFirstAndLastDigitNumbers();
            //ExtensionMethod.TotalPopulationOfTheTown();
            ExtensionMethod.currencynotesofdenomination();
        }

        private static void lines()
        {
            Console.WriteLine("***************************************************************************************");
        }

    }
}
