using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetUsC.Chapter_02
{
    static class CharactersASCIIValueDisplay
    {
        /// <summary>
        /// Any character is entered through the keyboard, 
        /// write a program to determine whether the character entered is 
        /// a capital letter, 65 – 90 
        /// a small case letter, 97 – 122 
        /// a digit or 48 – 57 
        /// a special symbol. - 0 - 47, 58 - 64, 91 - 96, 123 - 127
        /// The following table shows the range of ASCII values for various characters
        /// 
        /// </summary>
        /// <param name="ClassName"></param>
        public static void CharactersASCIIValue(this Chapter_02.ProfitAndLoss ClassName)
        {
            Console.WriteLine("Enter the characters");
            int  inputcharacterASCII = char.Parse(Console.ReadLine());
            if (inputcharacterASCII >=65 || inputcharacterASCII >= 90)
            {
                Console.WriteLine("it is a Upper Case letter");
            }
            else if  (inputcharacterASCII >= 97 || inputcharacterASCII >= 122)
            {
                Console.WriteLine("it is a lower Case letter");
            }
            else if (inputcharacterASCII >= 48 || inputcharacterASCII >= 57)
            {
                Console.WriteLine("it is a Number");
            }
            else if (inputcharacterASCII >= 0 || inputcharacterASCII >= 47 && 
                inputcharacterASCII >= 58 || inputcharacterASCII >= 64 &&
                inputcharacterASCII >= 91 || inputcharacterASCII >= 96 &&
                inputcharacterASCII >= 123 || inputcharacterASCII >= 127)
            {
                Console.WriteLine("it is a special symbol");
            }


        }
    }
}
