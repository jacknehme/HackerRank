using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay08.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            // 3
            // sam 99912222
            // tom 11122222
            // harry 12299933
            // sam
            // edward
            // harry

            string numberInput = Console.ReadLine();
            int number = int.Parse(numberInput);

            Dictionary<string, string> nameAndNumber = new Dictionary<string, string>();

            for(int i = 0 ; i < number ; i++)
            {
                string namAndNum = Console.ReadLine();
                string [] parsedNameNumber = namAndNum.Split();

                nameAndNumber.Add(parsedNameNumber[0], parsedNameNumber[1]);

            }

            string rline = Console.ReadLine();

            while(!string.IsNullOrEmpty(rline))
            {
                if(nameAndNumber.ContainsKey(rline))
                {
                    Console.WriteLine(rline + "=" + nameAndNumber[rline]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
                rline = Console.ReadLine();
            }
        }
    }
}
