using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayGround.practicePrograms
{
    class PrimeNumber
    {
        public void VerifythenumberisPrime()
        {
            Console.WriteLine("Enter your number");
            int input = Convert.ToInt32(Console.ReadLine());
            //int input = 12;
            int flag = 0;
            for (int i = 2; i < input / 2; i++)
            {
                if (input % i == 0)
                {
                    Console.WriteLine(input + " is Not Prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine(input + "is Prime Number");
            }
            
        }
    }
}
