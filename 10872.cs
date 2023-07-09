using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static int Factorial(int a)
        {
            if (a == 1)
            {
                return a;
            }
            else if (a == 0) 
            {
                return 1;
            }

            else
            {
                return a * Factorial(--a);
            }
        }
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(num));

        }
        

    }
}
