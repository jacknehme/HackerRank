using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay16.ExceptionsStringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            int num;

            try
            {
                num = Int32.Parse(S);
                Console.WriteLine(num);
            }
            catch(Exception ex)
            {
                if(ex is FormatException)
                {
                    Console.WriteLine("Bad String");
                }
                else
                {
                    throw;
                }

            }

            /*
            if(int.TryParse(S, out num))
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Bad String");
            }
            */
            Console.Read();         
        }
    }
}
