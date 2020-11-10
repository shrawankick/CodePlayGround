using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_01
{
    class Gross
    {
        /// <summary>
        /// Ramesh’s basic salary is input through the keyboard. 
        /// His dearness allowance is 40% of basic salary, and 
        /// house rent allowance is 20% of basic salary.
        /// Write a program to calculate his gross salary.
        /// 
        /// formula Net Salary = Gross Salary – Deductions
        /// 40/100 conversion 
        /// </summary>
        public void FindGrossSalaryofUser(){
            Console.WriteLine("Enter Basic Salary");
            int BasicSalary = Convert.ToInt32(Console.ReadLine());
            var DA =   0.4 * BasicSalary;
            //var HRA = BasicSalary * (40/100);
            var HRA = BasicSalary * 0.2;
            var Gross = BasicSalary + DA + HRA;
            Console.WriteLine($"Basic Salary {BasicSalary} and DA {DA} HRA {HRA}");
            Console.WriteLine($"Gross Salary is {Gross}");           
        }
    }
}
