using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    static class  reversedfiveDigitNumber
    {
        /// <summary>
        /// A five-digit number is entered through the keyboard.
        /// Write a program to obtain the reversed number and to determine 
        /// whether the original and reversed numbers are equal or not
        /// </summary>
        /// <param name=""></param>
        public static void ReverseOfFiveDigitNumberisSame(this Chapter_02.ProfitAndLoss inputClass)
        {
            Console.WriteLine("Enter Five digit Number");
            int inputnumber = Convert.ToInt32(Console.ReadLine());
            int refinput = inputnumber;
            if (inputnumber >= 100000)
            {
                Console.WriteLine("please enter 5 digits only ");
            }
            else
            {
                int Reverse = 0;
                while (inputnumber > 0)
                {
                    Reverse = Reverse * 10 + (inputnumber % 10);
                    inputnumber = inputnumber / 10;
                }
                // Console.WriteLine($"Reverse of the {refinput} is {Reverse}");
                if (refinput != Reverse)
                {
                    Console.WriteLine("both Numbers are Different");
                }
                else
                {
                    Console.WriteLine("Both the Numbers are equal");
                }

            }
            


        }
    }
}
