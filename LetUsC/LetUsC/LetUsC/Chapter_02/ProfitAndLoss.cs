using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    public class ProfitAndLoss
    {
        /// <summary>
        /// If cost price and selling price of an item is input through the keyboard, 
        /// write a program to determine whether the seller has made profit or incurred loss.
        /// Also determine how much profit he made or loss he incurred
        /// </summary>
        public void ProfitAndLossMadebyUser()
        {
            Console.WriteLine("Enter cost price of the Product");
            int Costprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Selling price of the Product");
            int SellingPrice = Convert.ToInt32(Console.ReadLine());
            if (Costprice < SellingPrice)
            {
                Console.WriteLine($"user Got the profit of {SellingPrice - Costprice}");
            }
            if (Costprice > SellingPrice)
            {
                Console.WriteLine($"user Got the Loss of { Costprice - SellingPrice}");
            }

            
            

        }
    }
}
