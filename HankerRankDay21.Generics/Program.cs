using System;

namespace HackerRankDay21.Generics
{
    class Program
    {
        // Add your code here

        private static void printArray<T>(int[] vInt)
        {
            for(int i = 0 ; i < vInt.Length ; i++)
                Console.WriteLine(vInt[i]);
        }

        private static void printArray<T>(string[] vString)
        {
            for(int i = 0 ; i < vString.Length ; i++) 
                Console.WriteLine(vString[i]);
        }

        static void Main(string[] args)
        {
            int[] vInt = new int[] { 1, 2, 3 };
            string[] vString = new string[] { "Hello", "World" };

            printArray<int>(vInt);
            printArray<string>(vString);
        }

    }
}
