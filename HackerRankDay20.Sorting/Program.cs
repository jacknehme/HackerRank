using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace hackerRankDay20.Sorting
{
    class Program
    {

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            // Track number of elements swapped during a single array traversal
            int numberOfSwaps = 0;

            for(int i = 0 ; i < n ; i++)
            {
                
                for(int j = 0 ; j < n - 1 ; j++)
                {
                    // Swap adjacent elements if they are in decreasing order

                    if(a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j+1] = temp;
                        numberOfSwaps++;
                    }
                }

                // If no elements were swapped during a traversal, array is sorted
                if(numberOfSwaps == 0)
                {
                    break;
                }
            }

            int firstElement = a[0];
            int lastElement = a[a.Length - 1];

            Console.WriteLine("Array is sorted in {0} swaps.", numberOfSwaps);
            Console.WriteLine("First Element: " + firstElement);
            Console.WriteLine("Last Element: " + lastElement);
            Console.Read();
        }

        
    }
}
