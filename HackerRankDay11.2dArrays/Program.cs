using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay11._2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                1 1 1 0 0 0
                0 1 0 0 0 0
                1 1 1 0 0 0
                0 0 2 4 4 0
                0 0 0 2 0 0
                0 0 1 2 4 0 

                -1 -1 0 -9 -2 -2
                -2 -1 -6 -8 -2 -5
                -1 -1 -1 -2 -3 -4
                -1 -9 -2 -4 -4 -5
                -7 -3 -3 -2 -9 -9
                -1 -3 -1 -2 -4 -5
            */

            int[][] arr = new int[6][];
            for(int arr_i = 0 ; arr_i < 6 ; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            bool firstTime = true;
            int sum = 0;
            int total = 0;
            int column = 0;

            for(int row = 0 ; row < arr.Length ; row++)
            {
                sum = 0;

                if(column + 3 > arr[0].Length )
                {
                    break;
                }
                

                Console.Write("Top Row:    ");
                for(int col = column ; col < column + 3 ; col++)
                {
                    Console.Write(arr[row][col]);
                    sum += arr[row][col];
                }

                Console.Write("\nMiddle:      ");
                Console.Write(arr[row + 1][column + 1]);
                sum += arr[row + 1][column + 1];

                Console.Write("\nBottom Row: ");
                for(int col = column ; col < column + 3 ; col++)
                {
                    Console.Write(arr[row+2][col]);
                    sum += arr[row+2][col];
                }

                Console.WriteLine("\nTotal: {0}", sum);
                Console.Write("\n");

                if(firstTime)
                {
                    firstTime = false;
                    total = sum;
                }

                if(sum > total)
                {
                     total = sum;
                }


                if(row + 3 == arr.Length)
                {
                    row = -1;
                    column++;
                }
            }

            Console.WriteLine("\nTotal: {0}", total);
            Console.Read();

        }
    }
}
