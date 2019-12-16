using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string!!");
            string toTest = Console.ReadLine();
            Regex emailReplace = new Regex(@"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}", RegexOptions.IgnoreCase);
            bool status = emailReplace.IsMatch(toTest);
            if (status == false)
            {
                Console.WriteLine("The string does not contain a valid email address!!");
            }
            else 
            {
                toTest = emailReplace.Replace(toTest, "wizkids@wizkidstest.com");
                Console.WriteLine("The string contains the valid email address so its replaced by wizkids@wizkidstest.com!!");
                Console.WriteLine(toTest);
            }
            Console.ReadKey();


        }
    }
}
