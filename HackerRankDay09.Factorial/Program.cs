using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay09.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());

            int fact = Factorial(number);

            Console.WriteLine(fact);
        }

        static int Factorial(int num)
        {
            if(num == 0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }

        }
    }
}
