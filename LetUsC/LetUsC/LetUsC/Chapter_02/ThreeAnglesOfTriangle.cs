using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    static class ThreeAnglesOfTriangle
    {
        /// <summary>
        /// Write a program to check whether a triangle is valid or not,
        /// when the three angles of the triangle are entered through the keyboard.
        /// A triangle is valid if the sum of all the three angles is equal to 180 degrees.
        /// </summary>
        public static void FindTheThreeAnglesOftriangel(this Chapter_02.ProfitAndLoss chapter2)
        {
            Console.WriteLine("Enter the angle of the side A");
            int AngleforSideA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the angle of the side B");
            int AngleforSideB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the angle of the side C");
            int AngleforSideC = Convert.ToInt32(Console.ReadLine());

           // string triangle = (AngleforSideA + AngleforSideB + AngleforSideC) == 180 ? "it is a triangle" : "it is not a Triangle";
            Console.WriteLine((AngleforSideA + AngleforSideB + AngleforSideC) == 180 ? "it is a triangle" : $"it is not a Triangle as some of the angles is {AngleforSideA + AngleforSideB + AngleforSideC}");
        }
    }
}
