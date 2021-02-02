using System;
using System.Collections;
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
            Threevaribles(inputArray);
            //UsingDictionar(inputArray);

        }

        private static void UsingDictionar(int[] inputArray)
        {
            Dictionary<int, int> valuePairs = new Dictionary<int, int>();
            foreach (var item in inputArray)
            {
                if (!valuePairs.ContainsKey(item))
                {
                    if (item == 0)
                    {
                        valuePairs.Add(item, 1);
                    }
                    else if (item < 0)
                    {
                        valuePairs.Add(item, 1);
                    }
                    else if (item > 0)
                    {
                        valuePairs.Add(item, 1);
                    }
                }
                else
                {
                    valuePairs[item]++;
                }
            }
            foreach (var items in valuePairs)
            {
                Console.WriteLine(items.Key + "," + items.Value);
            }
        }

        private static void Threevaribles(int[] inputArray)
        {
            int zero = 0;
            int Positive = 0;
            int neg = 0;

            foreach (int item in inputArray)
            {
                if (item == 0)
                {
                    zero++;
                }
                if (item > 0)
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



       
    }
}
