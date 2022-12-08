using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5PracticeProblem
{
    internal class Factor
    {
        public static void CheckFactor()
        {
            int num, i;
            Console.WriteLine("Enter the number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The factors are :");

            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
