using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_03
{
   static class PrintTheSumOfSeries
    {
        public static void TheSumOfSeries(this Chapter_03.FactorialValue classname)
        {
            var num = 5;
            float res = 0, fact = 1;
            for (int i = 1; i <= num; i++)
            {
                // fact variable store  
                // factorial of the i 
                fact = fact * i;

                res = res + (i / fact);
            }
            Console.WriteLine(res);
        }
    }
}
