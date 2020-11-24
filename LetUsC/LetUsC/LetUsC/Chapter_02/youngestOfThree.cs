using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    static class YoungestOfThree
    {
        /// <summary>
        /// If the ages of Ram, Shyam and Ajay are input through the keyboard, 
        /// write a program to determine the youngest of the three.
        /// </summary>
       public static void FindYongestOfthree(this Chapter_02.ProfitAndLoss inputClass)
        {
            Console.WriteLine("Add age of RAM");
            int ageOfRam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add age of Shyam");
            int ageOfShyam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add age of Ajay");
            int ageOfAjay = Convert.ToInt32(Console.ReadLine());
            if (ageOfRam< ageOfShyam && ageOfRam < ageOfAjay)
            {
                Console.WriteLine("Ram is Young");
            }
            else if(ageOfShyam < ageOfRam && ageOfShyam < ageOfAjay)
            {
                Console.WriteLine("SHyam is Young ");
            }
            else
            {
                Console.WriteLine("Ajay is young ");
            }

        }
    }
}
