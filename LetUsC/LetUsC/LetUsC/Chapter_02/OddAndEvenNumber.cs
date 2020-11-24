using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    static class OddAndEvenNumber{
        /// <summary>
        /// Any integer is input through the keyboard.
        /// Write a program to find out whether it is an odd number or even number.
        /// </summary>
        /// <param name="Chapter2"></param>
        public static void FindEvenAndOdNumber(this Chapter_02.ProfitAndLoss Chapter2) {
            Console.WriteLine("Enter the Number");
            int InputNumber = Convert.ToInt32(Console.ReadLine());
            if (InputNumber % 2 != 0){
                Console.WriteLine("Given Number is Odd");
            }
            else{
                Console.WriteLine("Given number is Even");
            }

        }
        /// <summary>
        /// Any year is input through the keyboard. Write a program to
        /// determine whether the year is a leap year or not.
        /// </summary>
        /// <param name="Chapter2"></param>
        public static void IsGivenYearisLeapyear(this Chapter_02.ProfitAndLoss Chapter2)
        {
            Console.WriteLine("Enter Year");
            int inputYear = Convert.ToInt32(Console.ReadLine());
            bool leapYear = (inputYear % 4 == 0) ? true : false;
            Console.WriteLine($"Given Year is a leap year ? {leapYear.ToString()}" );
            
        }
    }
}
