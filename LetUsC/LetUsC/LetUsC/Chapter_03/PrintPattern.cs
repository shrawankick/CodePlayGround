using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_03
{
    static class PrintPattern
    {
        public static void PatternPrint(this Chapter_03.FactorialValue classname)
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 65; j <= 71-i; j++)
                {
                   
                    Console.WriteLine(Convert.ToChar(j));
                }
                for (int space = 0; space <= i * 2 - 1; space++)
                {
                    Console.WriteLine( " ");
                }
                for (int k = 71 - i; k >= 65; k--)
                {
                    if (k != 71)
                    {
                        Console.WriteLine(Convert.ToChar(k));
                    }
                    else
                    { }
                }
                Console.WriteLine("\n");
            }

           

        }
    }
}
