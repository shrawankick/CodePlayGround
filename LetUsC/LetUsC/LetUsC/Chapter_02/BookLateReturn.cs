using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    static class BookLateReturn
    {
        /// <summary>
        ///A library charges a fine for every book returned late. For first
        ///5 days the fine is 50 paise, for 6-10 days fine is one rupee and
        ///above 10 days fine is 5 rupees. If you return the book after 30
        ///days your membership will be cancel. Write a program to
        ///accept the number of days the member is late to return the
        ///book and display the fine or the appropriate message. 
        /// </summary>
        /// <param name="classname"></param>
        public static void LateReturnChargeofBook(this Chapter_02.ProfitAndLoss classname)
        {
            Console.WriteLine("Enter the days of late return");
            int Latereturndays = Convert.ToInt32(Console.ReadLine());
            if (Latereturndays < 30)
            {
                if (Latereturndays < 09)
                {
                    if (Latereturndays<5)
                    {
                        Console.WriteLine(" fine is 50 paise");
                    }
                    else
                    {
                        Console.WriteLine("fine is one rupee");
                    }
                }
                else
                {
                    Console.WriteLine("fine is five rupees");
                }
                
            }
            else
            {
                Console.WriteLine("Membership is Canceled ");
            }
        }
    }
}
