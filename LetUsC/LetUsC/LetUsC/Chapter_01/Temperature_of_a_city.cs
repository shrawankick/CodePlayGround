using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_01
{
    class Temperature_of_a_city
    {

        //
        /// <summary>
        /// Temperature of a city in Fahrenheit degrees is input through the keyboard.
        /// Write a program to convert this temperature into Centigrade degrees.
        /// formula (32°F − 32) × 5/9 = 0°C
        /// (10°F − 32) × 5/9 = -12.22°C

        /// </summary>
        public void ConvertTempature()
        {
            Console.WriteLine("enter Temperature of a city in Fahrenheit degrees");
            var inputTempature = 0;
            try
            {
                inputTempature = Convert.ToInt32(Console.ReadLine());
                var temperatureInC = ((inputTempature - 32) * 5) / 9;
                Console.WriteLine($"temperature into Centigrade degrees is {temperatureInC} ");
            }
            catch (Exception eX)
            {
                Console.WriteLine(eX.Message);

            }




        }
    }
}
