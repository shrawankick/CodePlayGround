using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_01
{
    static class SumOfFirstandlastDigit
    {
        /// <summary>
        /// If a four-digit number is input through the keyboard, write a
        /// program to obtain the sum of the first and last digit of this
        /// number.
        /// </summary>
        /// <param name="number"></param>
        public static void SumOfFirstAndLastDigitNumbers(this Chapter_01.SumOfFiveDigitNumber number)
        {
            Console.WriteLine("Enter four digit Number");
            int inputnumber = Convert.ToInt32(Console.ReadLine());
            int refinput = inputnumber;
            if (inputnumber >= 10000)
            {
                Console.WriteLine("please enter 4 digits only ");
            }
            else
            {
                int lastDigit = inputnumber % 10;
                while (inputnumber >= 10)
                {
                    inputnumber = inputnumber / 10;
                }
                int firstDigit = inputnumber;

                Console.WriteLine($"Sum of first and last digit of Given number : {firstDigit + lastDigit}");
            }
        }

    }
}
