using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    static class ValidTriangle
    {
        /// <summary>
        ///If the three sides of a triangle are entered through the
        ///keyboard, write a program to check whether the triangle is
        ///valid or not. The triangle is valid if the sum of two sides is
        ///greater than the largest of the three sides.
        /// </summary>
        public static void FindifTriangleIsvalid(this Chapter_02.ProfitAndLoss classname)
        {
            Console.WriteLine("Enter 1 side of triangle");
            Console.WriteLine("Enter Side 2");
            Console.WriteLine("Enter Side 3");
            int side1 = Convert.ToInt32(Console.ReadLine());
            int side2 = Convert.ToInt32(Console.ReadLine());
            int side3 = Convert.ToInt32(Console.ReadLine());
            int largestof3Sides = (side1 > side2 && side1 > side3) ? side1 : (side2 > side1 && side2 > side3) ? side2 : side3;
            int SumOfSides = side1 + side2 + side3;
            if (SumOfSides - largestof3Sides > largestof3Sides)
            {
                Console.WriteLine("triangle is valid");
            }
            else
            {
                Console.WriteLine("it is not a valid Triangle");
            }
            

        }
    }
}
