using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    static class OddAndEvenNumber
    {
        public static void FindEvenAndOdNumber(this Chapter_02.ProfitAndLoss Chapter2)
        {
            Console.WriteLine("Enter the Number");
            int InputNumber = Convert.ToInt32(Console.ReadLine());
            if (InputNumber % 2 != 0)
            {
                Console.WriteLine("Given Number is Odd");
            }
            else
            {
                Console.WriteLine("Given number is Even");
            }

        }
    }
}
