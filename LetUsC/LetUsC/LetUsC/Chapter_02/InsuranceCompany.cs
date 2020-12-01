using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    static class InsuranceCompany
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Classname"></param>
        public static void rulesforinsurence(this Chapter_02.ProfitAndLoss Classname)
        {
            Console.WriteLine("Enter Age of person");
            int AgeOfperson = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Gender");
            string  GenderOfperson = Console.ReadLine();
            Console.WriteLine("Enter AreaOfLiving");
            Console.WriteLine("Person living in City then type C" +"/n"+ " if Person lives in Village type V ");
            string personLivingin = Console.ReadLine();
            string LivingAreais = (personLivingin == "c" ? "city" : "Village");
            Console.WriteLine("Enter Health Condition ");
            Console.WriteLine("if he has Excellent Condition then type E else Type P  ");
            string  HealthConditionOfperson = Console.ReadLine();
            HealthConditionOfperson = (HealthConditionOfperson == "E" ? "Excellent" : "Poor");

            if (25 <= AgeOfperson & AgeOfperson <= 35)
            {
                if (LivingAreais != "city" && HealthConditionOfperson != "Excellent")
                {
                    Console.WriteLine("premium is Rs. 6 per thousand and his policy cannot exceed Rs. 10,000.");
                }
                else if (GenderOfperson != "m")
                {
                    Console.WriteLine(" premium is Rs. 3 per thousand and her policy amount cannot exceed Rs. 1 lakh.");
                }
                else
                {
                    Console.WriteLine("premium is Rs. 4 per thousand and his policy amount cannot exceed Rs. 2 lakhs");
                }
            }
            else
            {
                Console.WriteLine(" person is not insured");
            }


        }
    }
}
