using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_01
{
    class InterchangeTheContents
    {
        /// <summary>
        /// Two numbers are input through the keyboard into two locations C and D.
        /// Write a program to interchange the contents of C and D.
        /// 
        /// I am Considering this Program is swapping two numbers(dynamic)
        ///
        /// </summary>
        public void InterchangeTheContentsOfTwoNumbers(){
            Console.WriteLine("Enter Number in C");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number in D");
            int D = Convert.ToInt32(Console.ReadLine());
            C = C + D;
            D = C - D;
            C = C - D;     
            Console.WriteLine($"New Value of C is {C} and New Value of D is {D} ");


        }
    }
}
