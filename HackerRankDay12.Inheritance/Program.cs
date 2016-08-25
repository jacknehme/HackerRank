using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay12.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for(int i = 0 ; i < numScores ; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.calculate() + "\n");
        }
    }

    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    // class Program and Person provide by HackerRank

    class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int identification, int[] scores) : base(firstName, lastName, identification)
        {
            testScores = scores;
        }

        public char calculate()
        {
            int total = 0;

            for(int i = 0 ; i < testScores.Length ; i++)
            {
                total += testScores[i];
            }

            double average = total*(1.0) / testScores.Length;

            if(90 <= average)
            {
                return 'O';
            }
            else if(80 <= average && average < 90)
            {
                return 'E';
            }
            else if(70 <= average && average < 80)
            {
                return 'A';
            }
            else if(55 <= average && average < 70)
            {
                return 'P';
            }
            else if(40 <= average && average < 55)
            {
                return 'D';
            }
            else if(average < 40)
            {
                return 'T';
            }
            else
            {
                return 'F';
            }
        }

    }
}
