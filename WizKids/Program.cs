using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizKids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string to check if it is palindrome!!");
            string strToCheck = Console.ReadLine();
            bool result = IsPalindrome(strToCheck);
            Console.WriteLine("The result for the string to be palindrome is " + result);
            Console.ReadKey();
        }

        private static bool IsPalindrome(string strToCheck)
        {
            char[] charStr = strToCheck.ToCharArray();
            Array.Reverse(charStr);

            string reversed = new string(charStr);

            bool isEqual = string.Equals(reversed, strToCheck);

            return isEqual;

        }
    }
}
