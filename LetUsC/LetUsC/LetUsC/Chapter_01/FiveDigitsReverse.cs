using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_01
{
   static  class FiveDigitsReverse
    {
        public static void Test(this Chapter_01.SumOfFiveDigitNumber number){
            Console.WriteLine("Method Name: extension method");
        }
        /// <summary>
        /// If a five-digit number is input through the keyboard, 
        /// write a program to reverse the number.
        /// </summary>
        /// <param name="number"></param>
        public static void ReverseOfFiveDigitNumber(this Chapter_01.SumOfFiveDigitNumber number)
        {
            Console.WriteLine("Enter Five digit Number");
            int inputnumber = Convert.ToInt32(Console.ReadLine());
            int refinput = inputnumber;
            if (inputnumber >= 100000){
                Console.WriteLine("please enter 5 digits only ");
            }
            else{
                int rev_num = 0;
                while (inputnumber > 0) {
                    rev_num = rev_num * 10 + (inputnumber % 10);
                    inputnumber = inputnumber / 10;
                }
                Console.WriteLine($"Reverse of the {refinput} is {rev_num}");
            }
        }
    }
}
