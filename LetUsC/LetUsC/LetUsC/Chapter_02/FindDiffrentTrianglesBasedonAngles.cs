using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    static class FindDiffrentTrianglesBasedonAngles
    {
        /// <summary>
        ///If the three sides of a triangle are entered through the keyboard,
        ///write a program to check whether the triangle is isosceles, equilateral, scalene or right angled triangle. 
        /// </summary>
        public static void TriangleBasedonAngles(this Chapter_02.ProfitAndLoss ClassName)
        {
            Console.WriteLine("Enter Angle A of triangle");
            Console.WriteLine("Enter Angle B");
            Console.WriteLine("Enter Angle C");
            int angleA = Convert.ToInt32(Console.ReadLine());
            int angleB = Convert.ToInt32(Console.ReadLine());
            int angleC = Convert.ToInt32(Console.ReadLine());
            if (angleA + angleB + angleC == 180){
                if (angleA == angleB && angleA == angleC && angleB == angleC){
                    Console.WriteLine("its a equilateral");
                }
                else if(angleA == 90 || angleB == 90 || angleC == 90){
                    Console.WriteLine("its a Right angle Triangle ");
                }
                else if (angleA != angleB && angleA!= angleC && angleB != angleC){
                    Console.WriteLine("its a scalene ");
                }
                if (angleA == angleB || angleA == angleC || angleB == angleC){
                    Console.WriteLine("its a isosceles");
                }
            }
            else
            {
                Console.WriteLine("its not a Triangle");
            }

        } 
    }
}
