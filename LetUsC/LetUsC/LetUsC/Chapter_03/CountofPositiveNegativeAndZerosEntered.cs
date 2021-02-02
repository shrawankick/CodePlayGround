using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_03
{
   static  class CountofPositiveNegativeAndZerosEntered
    {
        /// <summary>
        /// Write a program to enter the numbers till the user wants and at the end it 
       /// should display the count of positive, negative and zeros entered.
        /// </summary>
        /// <param name="classname"></param>
        public static void CountofPositiveNegativeAndZeros(this Chapter_03.FactorialValue classname)
        {
            int[] inputArray = new int[] { -1, 2, -4, -5, 0 };           
            int zero = 0;
            int Positive  = 0;
            int neg = 0;
            
            foreach (int item in inputArray)
            {
                if (item == 0)
                {
                    zero++;
                }
                if (item >0)
                {
                    Positive++;
                }
                if (item < 0)
                {
                    neg++;
                }

            }
            Console.WriteLine("Positive number" + Positive);
            Console.WriteLine("Zero number" + zero);
            Console.WriteLine("Negative number" + neg);

        }
        



        private static void NewMethod(int[] inputArray)
        {
           
        }
    }
}
