using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_01
{
   static class PopulationOfTheTown
    {
        /// <summary>
        /// In a town, the percentage of men is 52. 
        /// The percentage of total literacy is 48. 
        /// If total percentage of literate men is 35 of the total population, 
        ///write a program to find the total number of illiterate men and women if the population of the town is 80,000
        /// </summary>
        /// <param name="number"></param>
        public static void TotalPopulationOfTheTown(this Chapter_01.SumOfFiveDigitNumber number)
        {
            int TotalPopulationOfTheTown = 80000;
            int PopulationOfMen = (52 * TotalPopulationOfTheTown) / 100;
            int PopulationOfWomen = TotalPopulationOfTheTown - PopulationOfMen;
            int literatePopulation = (48 * TotalPopulationOfTheTown) / 100;
            int literateMen = (35 * TotalPopulationOfTheTown) / 100;
            int literateWomen = literatePopulation - literateMen;

            Console.WriteLine($"The Total population of {TotalPopulationOfTheTown} \n " +
                $"Total men {PopulationOfMen}, total women {PopulationOfWomen} " +
                $"\n Total literate Population {literatePopulation} \n" +
                $" literate Men {literateMen} literate women {literateWomen}");


        }
    }
}
