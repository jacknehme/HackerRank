using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay10.BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
             * Output Format
             * Print a single base-10 integer denoting the maximum number of consecutive 's in the binary representation of n.
             * 
             */

            int n = Convert.ToInt32(Console.ReadLine());
            List<int> bits = new List<int>();

            int remainder = 0;

            while(n > 0)
            {
                remainder = n % 2;
                bits.Add(remainder);
                n = n / 2;
            }

            bits.Reverse();

            int countOnes = 0;
            int rtnOnes = 0;

            foreach(int i in bits)
            {
                if(i == 1)
                {
                    countOnes += 1;
                }
                else
                {
                    if(countOnes > rtnOnes)
                    {
                        rtnOnes = countOnes;
                        countOnes = 0;
                    }
                    else
                    {
                        countOnes = 0;
                    }
                }
            }
            if(countOnes > rtnOnes)
            {
                Console.WriteLine(countOnes);
            }
            else
            {
                Console.WriteLine(rtnOnes);
            }

            Console.ReadLine();
        }
    }
}
