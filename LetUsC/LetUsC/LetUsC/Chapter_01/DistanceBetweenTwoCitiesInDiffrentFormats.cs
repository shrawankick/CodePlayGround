using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_01
{
    class DistanceBetweenTwoCitiesInDiffrentFormats
    {
        /// <summary>
        /// The distance between two cities (in km.) is input through the 
        /// keyboard.Write a program to convert and print this distance 
        /// in meters, 
        /// feet, 
        /// inches and 
        /// centimeters.
        /// </summary>
        public void DistanceBetweenTwoCities()
        {
            Console.WriteLine("Enter Distance between two cities (in km.) ");
            int DistanceinKM = Convert.ToInt32(Console.ReadLine());
            int inMeters = DistanceinKM * 1000;
            var  inFeet = inMeters * 3.28084;
            var inInches = inFeet * 12;
            int InCentiMeters = DistanceinKM * 100000;
            Console.WriteLine($"Distance Between Two Cities " +
                $"in km {DistanceinKM}, " +
                $"in Meters {inMeters}, " +
                $"in ft {inFeet}, " +
                $"in Inches {inInches}, " +
                $"In CentiMeters {InCentiMeters}");

        }
    }
}
