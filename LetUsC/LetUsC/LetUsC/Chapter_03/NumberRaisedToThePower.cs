using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_03
{
    
    static class NumberRaisedToThePower
    {
        /// <summary>
        /// Two numbers are entered through the keyboard. 
        /// Write a program to find the value of one number raised to the power of another.
        /// </summary>
        public static void TheNumberRaisedToThePower(this Chapter_03.FactorialValue className)
        {
            Console.WriteLine("Enter the Number");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Power of the number");
            int PowerOfNumber = Convert.ToInt32(Console.ReadLine());
            int raisedToThePower = 1;
            for (int i = 0; i < PowerOfNumber; i++)
            {               
                raisedToThePower = raisedToThePower * inputNumber;
            }
            Console.WriteLine($"{inputNumber} to the Power of {PowerOfNumber} is {raisedToThePower}");
        }
    }
}
