using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_03
{
    static class generateAllCombinations
    {
        public static void  GenerateAllCombinationsofNumbers(this Chapter_03.FactorialValue classname)
        {
            var i = 0;
            var j = 0;
            var k = 0;
            for ( i = 1; i < 4; i++)
            {
                for ( j = 1; j < 4; j++)
                {
                    for ( k = 1; k < 4; k++)
                    {
                        Console.WriteLine(i+" "+j+" "+k+" ");
                        
                    }
                }
            }
        }
    }
}
