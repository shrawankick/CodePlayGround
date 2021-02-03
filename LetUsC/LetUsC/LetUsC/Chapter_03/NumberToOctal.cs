using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_03
{
    static class NumberToOctal
    {
        public static void ConvertNumberToOctal(this Chapter_03.FactorialValue classname)
        {
            int  i, j, OctalNumber = 0;

            int Number = 6;
            i = 1;
            for (j = Number; j > 0; j = j / 8)
            {
                OctalNumber = OctalNumber + (j % 8) * i;
                i = i * 10;
                Number = Number / 8;
            }

            Console.WriteLine(Number + "is "+ OctalNumber);
        }
    }
}
