using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    static class Class1
    {
        /// <summary>
        /// Given three points (x1, y1), (x2, y2) and (x3, y3), 
        /// write a program to check if all the three points fall on one straight line
        /// </summary>
        /// <param name="classname"></param>
        public static void ThreePointsFallOnOneStraightLine(this Chapter_02.ProfitAndLoss classname)
        {
            Console.WriteLine("enter x1,y1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter x2,y2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter x3,y3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            //(x2−x1)(y3−y1)−(y2−y1)(x3−x1)
            //https://math.stackexchange.com/questions/701862/how-to-find-if-the-points-fall-in-a-straight-line-or-not
            int collinearity = (((x2 - x1) * (y3 - y1)) - ((y2 - y1) * (x3 - x1)));
            Console.WriteLine(collinearity==0? 
                "all the three points fall on one straight line":
                "all the three points not fall on one straight line");

        }
    }
}
