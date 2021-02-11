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
                for (int j = i; j < 10-i; j++)
                {
                    //String.Format(Convert.ToChar(j).ToString());
                    // Console.WriteLine(String.Format(Convert.ToChar(j).ToString()));
                    //StringBuilder builder = new StringBuilder();
                    // Console.WriteLine(builder.Append(String.Format(Convert.ToChar(j).ToString())));
                    
                    Console.WriteLine(" ");
                }
                Console.WriteLine("#");
            }

           

        }
    }
}
