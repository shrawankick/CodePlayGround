using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_03
{
    static class PrintAllTheASCIIValues
    {
        /// <summary>
        /// Write a program to print all the ASCII values and their
        ///equivalent characters using a while loop.The ASCII values
       ///vary from 0 to 255.
        /// </summary>
        public static void PrintAllASCIIValues(this Chapter_03.FactorialValue classValue)
        {
            //for (int i = 0; i <= 255; i++)
            //{
            //    char character = Convert.ToChar(i);
            //    Console.WriteLine(i + " value "+ character);
            //}

            int i = 0;
            while (i <= 255)
            {
                char character = Convert.ToChar(i);
                Console.WriteLine($"ASCII Value {i} character is {character} ");
                i++;
            }
            
        }
    }
}
