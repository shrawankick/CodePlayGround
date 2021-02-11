using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_03
{
    static class PrintPrimeNumbers
    {
        public static void PrintPrimeNumbersTill(this Chapter_03.FactorialValue classname)
        {
            for (int PrimeNumber = 0; PrimeNumber < 301; PrimeNumber++)
            {
                int input = PrimeNumber;
                bool isPrime = true;
                for (int i = 2; i < input / 2; i++)
                {
                    if (input % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(input + "is Prime Number");
                }
                else
                {
                    //Console.WriteLine(input + "is not a Prime Number");
                }
            }
        }
    }
}
