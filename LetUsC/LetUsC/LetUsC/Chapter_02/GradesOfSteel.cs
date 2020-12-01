using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    static class GradesOfSteel
    {
        /// <summary>
        /// Write a program, which will require the user to give values of
        /// hardness, carbon content and tensile strength of the steel
        ///under consideration and output the grade of the steel.
        /// </summary>
        public static void FindTheGradeOfSteel(this Chapter_02.ProfitAndLoss className)
        {
            Console.WriteLine("Enter the Hardness of the Steel");
            int HardnessofSteel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Carbon Content of the steel");
            float CorbonContentofSteel = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Tensile strength of the steel ");
            int TensileStrenthofSteel = Convert.ToInt32(Console.ReadLine());
            if (HardnessofSteel>50 && CorbonContentofSteel < 0.7 && TensileStrenthofSteel > 5600)
            {
                Console.WriteLine("Grade 10 Steel");
            }
            else if (HardnessofSteel > 50 && CorbonContentofSteel < 0.7)
            {
                Console.WriteLine("Grade 9 Steel");
            }
            else if (CorbonContentofSteel < 0.7 && TensileStrenthofSteel > 5600)
            {
                Console.WriteLine("Grade 8 Steel");
            }
            else if (HardnessofSteel > 50  && TensileStrenthofSteel > 5600)
            {
                Console.WriteLine("Grade 7 Steel");
            }
            else if (HardnessofSteel < 50 || CorbonContentofSteel > 0.7 || TensileStrenthofSteel < 5600)
            {
                Console.WriteLine("Grade 6 Steel");
            }
            else
            {
                Console.WriteLine("Grade 5 Steel");
            }
            
        }
    }
}
