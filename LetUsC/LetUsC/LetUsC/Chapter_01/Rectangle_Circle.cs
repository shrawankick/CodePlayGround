using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_01
{
    class Rectangle_Circle
    {
        /// <summary>
        /// The length & breadth of a rectangle and radius of a circle 
        /// are input through the keyboard.
        /// Write a program to calculate the area & perimeter of the rectangle, 
        /// and the area & circumference of the circle.
        /// 
        /// A=w*l
        /// P=2(l+w)
        /// 
        /// Area of Circle 
        /// A=πr2
        /// C=2πr
        /// </summary>
        public void RectangleOrCircle()
        {
            Console.WriteLine("length of rectangle");
            var LengthOfRectangle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("breadth of rectangle");
            var BreadthOfRectangle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Radius of Circle");
            var RadiusOfCircle = Convert.ToInt32(Console.ReadLine());
            var AreaOfRectangle = LengthOfRectangle * BreadthOfRectangle;
            var perimeterOfRectangle = 2 * AreaOfRectangle;
            var AreaOfCircle = Math.PI * RadiusOfCircle * RadiusOfCircle;
            var circumference = 2 * Math.PI * RadiusOfCircle;
            Console.WriteLine($"if length of rectangle is {LengthOfRectangle} and " +
                $"breadth of rectangle is {BreadthOfRectangle} " +
                $"then Area is {AreaOfRectangle} And " +
                $"perimeter {perimeterOfRectangle}. " +
                $"\n Area circle is {AreaOfCircle} when Radius of Circle is {RadiusOfCircle} and " +
                $"Circumference of Circle is {circumference}");
            
        }
    }
}
