using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_01
{
    class SumOfFiveDigitNumber
    {
        /// <summary>
        /// If a five-digit number is input through the keyboard, write a
        /// program to calculate the sum of its digits.
        //(Hint: Use the modulus operator ‘%’)
        /// </summary>
        public void Sumoffivedigits()
        {
            Console.WriteLine("enter Five Digit number");
            int InputNumber = Convert.ToInt32(Console.ReadLine());
            int refinput = InputNumber;
            if (InputNumber <= 100000)
            {

                int sum = 0;
                while (InputNumber != 0)
                {
                    sum += InputNumber % 10;
                    InputNumber = InputNumber / 10;
                }

                Console.WriteLine($"Sum of the digits of {refinput} is {sum}");
            }
            else
            {
                Console.WriteLine("Enter Valid number in five digits ");
            }
        }
    }
}
