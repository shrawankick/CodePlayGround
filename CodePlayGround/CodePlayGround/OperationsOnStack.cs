using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayGround
{
    class OperationsOnStack
    {
        //Given a stack of integers and Q queries.The task is to perform the operation on stack according to the query.
        //The queries can be of 4 types:
        //i x: (adds element x in the stack).
        //r: (removes the topmost element from the stack).
        //h: Prints the topmost element.
        //f y: (check if the element y is present or not in the stack). Print "Yes" if present, else "No".
        //https://practice.geeksforgeeks.org/problems/operations-on-stack/1/?track=DSA-Foundation-Final-Stack&batchId=193
        /// <summary>
        /// 
        /// </summary>
        public void OperationsOnStacks()
        {
            // throw new NotImplementedException();
            //Console.WriteLine("call from OperationsOnStack");
            //Stack myStack = new Stack();
            //string operation;
            var InputForOperationsOnStacks = new List<KeyValuePair<string, int>>();
            InputForOperationsOnStacks.Add(new KeyValuePair<string, int>("i", 2));
            InputForOperationsOnStacks.Add(new KeyValuePair<string, int>("i", 4));
            InputForOperationsOnStacks.Add(new KeyValuePair<string, int>("i", 3));
            InputForOperationsOnStacks.Add(new KeyValuePair<string, int>("i", 5));
            InputForOperationsOnStacks.Add(new KeyValuePair<string, int>("h",0));
            InputForOperationsOnStacks.Add(new KeyValuePair<string, int>("f", 8));

            foreach (var element in InputForOperationsOnStacks)
            {
                switch (element.Key)
                {
                    case "i":
                        Insert(element.Value);
                        break;
                    case "r":
                        RemoveTopmostElement();
                        break;
                    case "f":
                        FindElementinStack(element.Value);
                        break;
                    case "h":
                        PrintTopmostElemnt();                
                        break;
                    default:
                        break;
                }

            }

        }

        private void PrintTopmostElemnt()
        {
            operation = "printTop";
            stackoperation(operation);
        }

        private void FindElementinStack(int value)
        {
            operation = "find";
            stackoperation(operation,value);
        }

        string operation;
        private void RemoveTopmostElement()
        {
            operation = "remove";
            stackoperation(operation);

        }

        public void Insert( int i )
        {
            operation = "insert";
            stackoperation(operation, i);
        }





        public void stackoperation(string opr ,int i = 0)
        {
            Stack TestStack = new Stack();
            switch (opr)
            {
                case "insert":
                    TestStack.Push(i);
                    Console.WriteLine("inserted "+ i);
                    break;
                case "remove":
                    TestStack.Pop();
                    break;
                case "find":
                    //myStack.Contains(i);
                    Console.WriteLine(TestStack.Contains(i));
                    break;
                case "printTop":
                    Console.WriteLine(TestStack.Peek());
                    break;
            }

        }
    }
}
