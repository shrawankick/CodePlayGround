using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    static  class AreaGreaterThanItsPerimeter
    {
        /// <summary>
        /// Given the length and breadth of a rectangle, 
        /// write a program to find whether the area of the rectangle is greater than its perimeter.
        /// For example, 
        /// the area of the rectangle with length = 5 and 
        /// breadth = 4 is greater than its perimeter
        /// </summary>
        /// <param name="ClassName"></param>
        public static void Areaoftherectangleisgreaterthanitsperimeter(this Chapter_02.ProfitAndLoss ClassName)
        {
            Console.WriteLine("length of rectangle");
            var LengthOfRectangle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("breadth of rectangle");
            var BreadthOfRectangle = Convert.ToInt32(Console.ReadLine());
            var AreaOfRectangle = LengthOfRectangle * BreadthOfRectangle;
            var perimeterOfRectangle = 2 * AreaOfRectangle;
            Console.WriteLine($"area is {AreaOfRectangle} and perimeter is {perimeterOfRectangle}");
            Console.WriteLine((AreaOfRectangle>perimeterOfRectangle)? "area is greater than its perimeter": "area is less than its perimeter");
        }
    }
}
