using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_03
{
    class FactorialValue
    {
        /// <summary>
        /// 
        /// </summary>
        public void FindTheFactorialvalue()
        {
            Console.WriteLine("Enter the number");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= inputNumber; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"the factorial of the {inputNumber} is {factorial}");

        }
    }
}
