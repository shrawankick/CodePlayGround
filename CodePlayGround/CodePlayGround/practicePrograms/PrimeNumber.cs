using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayGround.practicePrograms
{
    class PrimeNumber{
        public void VerifythenumberisPrime(){
            Console.WriteLine("Enter your number");
            int input = Convert.ToInt32(Console.ReadLine());
            boolean isPrime = true;
            for (int i = 2; i < input / 2; i++){
                if (input % i == 0){
                    isPrime = false;
                    break;
                }
            }
            
            if (isPrime){
                Console.WriteLine(input + "is Prime Number");
            } else {
                Console.WriteLine(input + "is not a Prime Number");
            }
        }
    }
}
