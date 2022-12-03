using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class LP1_Fs
    {
        public static void Fibonacci_Series()
        {
            //Varaiable
            int a = 0, b = 1, c, i;

            Console.WriteLine("How MANY N NUMBERS YOU WANT:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(a + " " + b + " ");
            for (i = 2; i < n; ++i)//For Loop
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
