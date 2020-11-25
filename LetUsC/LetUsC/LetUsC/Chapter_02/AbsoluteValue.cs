using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
   static  class AbsoluteValue
    {
        /// <summary>
        /// Find the absolute value of a number entered through the keyboard.
        /// number less than zero should be multiplied with - value 
        /// </summary>
        /// <param name="ClassName"></param>
       public static void FindtheAbsoluteValueofANumber(this Chapter_02.ProfitAndLoss ClassName )
        {
            Console.WriteLine("enter the value");
            int number = Convert.ToInt32(Console.ReadLine());
            //Math.Abs(number);
            if (number < 0){
                number = number * (-1);
            }      
            Console.WriteLine($"absolute value of a number is {number}");           
        }
    }
}
