using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_03
{
    static  class PrintSmileface
    {
        public static void PrintSmilefaceinScreen(this Chapter_03.FactorialValue classname)
        {
            int i;
            char ch = Convert.ToChar(1); //ASCII value for smiling face is 1

            for (i = 0; i < 2000; i++)
            {
                Console.WriteLine(ch + "\n");
            }
        }
            
        
}
}
