using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_03
{
    static class ArmstrongNumbers
    {
        /// <summary>
        /// 
        /// </summary>
        public static void FindArmstrongNumbers(this Chapter_03.FactorialValue classname)
        {
            for (int i = 0; i < 500; i++)
            {
                int inputnumber = i;
                int temporary = inputnumber;
                int sum = 0;
                while (inputnumber > 0)
                {
                    int remainder = inputnumber % 10;
                    sum = sum + (remainder * remainder * remainder);
                    inputnumber = inputnumber / 10;
                }
                if (temporary == sum)
                    Console.Write($"{temporary} is Armstrong Number" + "\n");
            }

           
        }

    }
}
