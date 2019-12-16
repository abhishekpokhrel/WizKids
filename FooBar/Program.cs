using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing numbers from 1 to 100.");
            for (int i = 1; i <= 100; i++) 
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FooBar");
                    }
                    else
                        Console.WriteLine("Foo");
                }
                else if (i % 5 == 0)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("FooBar");
                    }
                    else
                        Console.WriteLine("Bar");
                }
                else
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
