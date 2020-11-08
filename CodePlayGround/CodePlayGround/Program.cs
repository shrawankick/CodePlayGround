using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            //DuplicateCharacters("zaabbcddww");
            //PossibleSubstring("abcdef");
            //SecondBiggestElementInArray();
            //StringResverse();
            //CountTheOccurenceOfEachChar("Mississippi");
            //CountTheOccurenceOfEachChar(string.Empty);
            //VerifythenumberisPrime();
            //TestingTryCatch();
            //FindtheNthlargestNumberinArrayUsingBuiltinfun();
            // FindtheNthlargestNumberinArray();
            //FindtheNthlargestNumberinArrayUsingStacks();
            //OperationsOnStack operationsOnStack = new OperationsOnStack();
            //operationsOnStack.OperationsOnStacks();

            practicePrograms.PrimeNumber primeNumber = new practicePrograms.PrimeNumber();
            primeNumber.VerifythenumberisPrime();
           

            Console.ReadLine();
        }

       

        private static void FindtheNthlargestNumberinArrayUsingStacks()
        {
            int n = 5;
            int[] myarray = new int[] { 30, 0, 5, 10, 15, 15, 20, 20, 25, 35 };
            PrintArray(myarray);
            int length = myarray.Length;
            if (n > myarray.Length || n == 0)
            {
                Console.WriteLine("there is no Zero highest or the length of array is less-than the Given highest number  ");
                Console.WriteLine("there is no " + n + " highest");
            }
            else
            {
                //implement sorting 
                Stack<int> inputStack = new Stack<int>();                
                foreach (var item in myarray)
                {
                    // Console.WriteLine(item);
                    inputStack.Push(item);
                }
                Stack<int> SortedStack = SortStackUsingWhileloop(inputStack);
                Console.WriteLine("The Sorted Array: ");
                PrintStack(SortedStack);
                //
                int[] SortedStackConvertedToarray = SortedStack.ToArray();

                int k = 1;
                for (int i = 0; i < length; i++)
                {
                    if (SortedStackConvertedToarray[i] != SortedStackConvertedToarray[k - 1])
                    {
                        SortedStackConvertedToarray[k] = SortedStackConvertedToarray[i];
                        k++;
                    }
                }
                // Console.WriteLine("All unique Elements");

                Console.WriteLine('\n');
                Console.WriteLine("The " + n + " largest number in array is " + myarray[myarray.Length - n]);

            }



        }
        /// <summary>
        /// we are using the Temporary Stack to sort the input array and we return 
        /// the Stack of sorted array 
        /// </summary>
        /// <param name="input">we need to add the Stack</param>
        /// <returns></returns>
        private static Stack<int> SortStackUsingWhileloop(Stack<int> input)
        {
            Stack<int> tmpStack = new Stack<int>();
            while (input.Count > 0)
            {
                int tmp = input.Pop();
                while (tmpStack.Count > 0 && tmpStack.Peek() > tmp)
                {
                    input.Push(tmpStack.Pop());
                }
                tmpStack.Push(tmp);
            }
            return tmpStack;
        }
        /// <summary>
        /// we are Printing the stacks 
        /// </summary>
        /// <param name="s"></param>
        public static void PrintStack(Stack<int> s)
        {
            if (s.Count == 0)
                return;

            int x = s.Peek();
            s.Pop();
            PrintStack(s);
            Console.Write(x + " ");
            s.Push(x);

        }

        public static void sortStack(Stack<int> tmpStack)
        {
            if (tmpStack.Count > 0)
            {
                int x = (int)tmpStack.Peek();
                tmpStack.Pop();

                sortStack(tmpStack);
                sortedInsert(tmpStack, x);
            }
            // throw new NotImplementedException();
        }

        public static void sortedInsert(Stack<int> tmpStack, int x)
        {
            if (tmpStack.Count == 0 || x > (int)tmpStack.Peek())
            {
                tmpStack.Push(x);
                return;
            }
            //throw new NotImplementedException();
        }

        private static void FindtheNthlargestNumberinArray()
        {
            int n = 5;
            int[] myarray = new int[] { 30, 0, 5, 10, 15, 15, 20, 20, 25, 35 };
            PrintArray(myarray);
            int length = myarray.Length;
            if (n > myarray.Length || n == 0)
            {
                Console.WriteLine("there is no Zero highest or the length of array is less-than the Given highest number  ");
                Console.WriteLine("there is no " + n + " highest");
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = i + 1; j < length; j++)
                    {
                        if (myarray[i] > myarray[j])
                        {
                            int temp = myarray[i];
                            myarray[i] = myarray[j];
                            myarray[j] = temp;
                        }

                    }
                }
                // Console.WriteLine("sorted");
                // PrintArray(myarray);

                int k = 1;
                for (int i = 0; i < length; i++)
                {
                    if (myarray[i] != myarray[k - 1])
                    {
                        myarray[k] = myarray[i];
                        k++;
                    }
                }
                // Console.WriteLine("All unique Elements");
                // PrintArray(myarray);

                Console.WriteLine("The " + n + " largest number in array is " + myarray[myarray.Length - n]);


            }

        }


        /// <summary>
        /// Printing the Array for reference 
        /// </summary>
        /// <param name="testArray"></param>
        private static void PrintArray(int[] testArray)
        {
            Console.WriteLine("The input array: ");
            foreach (var item in testArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }

        private static void FindtheNthlargestNumberinArrayUsingBuiltinfun()
        {
            int n = 4;
            int[] myarray = new int[] { 30, 0, 5, 10, 15, 15, 20, 20, 25, 35 };
            if (n <= myarray.Length)
            {
                Array.Sort(myarray);
                Array.Reverse(myarray);

                // int[] findNthLargeselement = myarray;
                //Console.WriteLine("Sorted");
                //foreach (var item in findNthLargeselement)
                //{

                //    Console.WriteLine(item + " , ");
                //}
                //Console.WriteLine("Distinct");
                int[] ArrayWithDistinctElements = myarray.Distinct().ToArray();
                //foreach (var item in ArrayWithDistinctElements)
                //{
                //    Console.WriteLine(item + " , ");
                //}
                Console.WriteLine("The " + n + " largest number in array is " + ArrayWithDistinctElements[n - 1]);
                Console.WriteLine();
                // throw new NotImplementedException();
            }
        }

        private static void TestingTryCatch()
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
            throw new NotImplementedException();
        }

        private static void VerifythenumberisPrime()
        {

            int input = 12;
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
            //throw new NotImplementedException();
        }

        private static void CountTheOccurenceOfEachChar(string inputword)
        {


            Dictionary<Char, int> CharCount = new Dictionary<char, int>();

            foreach (var eachLetter in inputword)
            {
                if (eachLetter != ' ')
                {
                    if (!CharCount.ContainsKey(eachLetter))
                    {
                        CharCount.Add(eachLetter, 1);
                    }
                    else
                    {
                        CharCount[eachLetter]++;
                    }
                }
            }



            foreach (var item in CharCount)
            {
                Console.WriteLine(item.Key + "," + item.Value);
            }
            // throw new NotImplementedException();
        }

        private static void StringResverse()
        {

            string str, str1 = "";
            int i, l;
            str = "sravan";
            l = str.Length - 1;
            for (i = l; i >= 0; i--)
            {
                str1 = str1 + str[i];
            }
            Console.WriteLine(str1);



        }

        /// <summary>
        /// 
        /// </summary>
        private static void SecondBiggestElementInArray()
        {
            int[] myarray = new int[] { 1, 2, 3, 4, 5, 6, 6, 6, 6, 3, 3, 7, 7, 0 };
            int firstBiggest = int.MinValue;
            int secondBiggest = int.MinValue;
            foreach (var i in myarray)
            {
                if (i > firstBiggest)
                {
                    secondBiggest = firstBiggest;
                    firstBiggest = i;

                }
                else if (i > secondBiggest && i != firstBiggest)
                {
                    secondBiggest = i;
                }

            }
            Console.WriteLine(secondBiggest);
            Console.ReadLine();
        }

        private static void PossibleSubstring(string str)
        {
            // string str = "sravan";
            //string result = String.Empty;

            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.WriteLine(subString);
                }


            }
            Console.ReadLine();

        }

        private static void DuplicateCharacters(string str)
        {
            // = "aabbcddww";
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
