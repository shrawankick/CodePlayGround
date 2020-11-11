using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_01
{
    class marks_obtained_by


    {

        /// <summary>
        /// If the marks obtained by a student in five different subjects
        ///are input through the keyboard, 
        ///find out the aggregate marks and 
        ///percentage marks obtained by the student.
        ///Assume that the maximum marks that can be obtained by a student in each
        ///subject is 100.
        /// </summary>
       public void MarksObtainedByAStudentInFiveDifferentSubjects()
        {
            Console.WriteLine("Enter the marks for Subject 1");
            var Subject1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks for Subject 2");
            var Subject2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks for Subject 3");
            var Subject3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks for Subject 4");
            var Subject4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks for Subject 5");
            var Subject5 = Convert.ToInt32(Console.ReadLine());

            int Aggregate = Subject1
                         + Subject2
                         + Subject3
                         + Subject4
                         + Subject5;

            var Percentage = Aggregate * 0.2;
            Console.WriteLine($"Percentage is {Percentage} and the Aggregate is {Aggregate} ");

            
        }
    }
}
