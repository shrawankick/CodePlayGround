using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_01
{
   static  class CurrencyNotesOfDenominations
    {
        /// <summary>
        /// A cashier has currency notes of denominations 10, 50 and 100.
        /// If the amount to be withdrawn is input through the keyboard in hundreds, 
        /// find the total number of currency notes of each denomination the cashier will have to give to the withdrawer.
        /// </summary>
        public static void currencynotesofdenomination(this Chapter_01.SumOfFiveDigitNumber number)
        {
            Console.WriteLine("Enter Amount to WithDraw");
            int InputAmount = Convert.ToInt32(Console.ReadLine());
            int Hunderednotes = InputAmount / 100;
            int fiftynotes = (InputAmount % 100) / 50;
            int Tens = (((InputAmount% 100))%50)/ 10;
            int change = (((InputAmount % 100)) % 50) % 10;
            Console.WriteLine($"input Amount is {InputAmount} \n " +
                $"the notes in 100 {Hunderednotes} \n, " +
                $"in 50 is {fiftynotes} \n 10 {Tens}  and  \n change {change} " );
        }
    }
}
