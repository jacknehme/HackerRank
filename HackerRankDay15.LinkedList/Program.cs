using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay14.Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;
        private int temp = 0;

        public Difference(int[] a)
        {
            elements = a;
        }

        public void computeDifference()
        {
            maximumDifference = 0;
            for(int i = 0 ; i < elements.Length ; i++)
            {
                for(int j = 0 ; j < elements.Length ; j++)
                {
                    temp = Math.Abs(elements[i]) - Math.Abs(elements[j]);

                    if(maximumDifference < temp)
                    {
                        maximumDifference = temp;
                    }

                }

            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
            Console.Read();
        }
    }

}
