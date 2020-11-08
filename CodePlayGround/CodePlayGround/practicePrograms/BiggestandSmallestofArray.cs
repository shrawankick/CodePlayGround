using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayGround.practicePrograms
{
    class LargestandSmallestofArray
    {
        /// <summary>
        /// How do you find the largest and smallest number in an unsorted integer array?
        /// input=[12,34,-34,56,78, 3, 6]
        /// op should be  largest 78
        /// Smallest is -34
        /// </summary>
        public void LargestAndSmallestofArray(){
            int[] myarray = new int[] { 12, 34, -34, 56, 78, 3, 6 };
            int Largest = int.MinValue;
           int smallest = int.MaxValue;
            foreach (var numberInArray in myarray){
                if (numberInArray > Largest){
                    Largest = numberInArray;
                }
                if (numberInArray < smallest){
                    smallest = numberInArray;
                }

            }
            Console.WriteLine("the Largest of Array is " + Largest);
            Console.WriteLine("the smallest of Array is " + smallest);

            Console.ReadLine();
        }
    }
}
