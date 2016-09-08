using System;

namespace HackerRankDay19.Interfaces
{

    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    //Write your code here

    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int length = n;
            int sum = 0;
            for(int i = 1 ; i <= length ; i++)
            {
                if(n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }

    // My code ends here

    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
            Console.Read();
        }
    }
}



