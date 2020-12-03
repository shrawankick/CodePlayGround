using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    static class workerefficiency
    {
        /// <summary>
        ///  If the time taken by the worker is input through the keyboard, 
        ///  find the efficiency of the worker.
        /// </summary>
        public static void FindWorkerEfficiency(this Chapter_02.ProfitAndLoss className)
        {
            Console.WriteLine("Enter the Time taken by the worker");
            int timeTakenByworker = Convert.ToInt32(Console.ReadLine());
            if (timeTakenByworker <= 5)
            {
                if (timeTakenByworker <= 3)
                {
                    if (timeTakenByworker < 2)
                    {
                        Console.WriteLine("worker is highly efficient");
                    }
                    else
                        Console.WriteLine("the worker is ordered to improve speed");
                }
                else
                    Console.WriteLine("the worker is given training to improve his speed");
            }
            else
                Console.WriteLine("Worker Can Leave The company");
        }
    }
}
