using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5PracticeProblem
{
    internal class EvenOrOdd
    {
        public static void CheckEvenOrOdd()
        {
            int a;
            Console.WriteLine("Enter a number :");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.ReadLine();
                Console.WriteLine("Enter the number is Even");

            }
            else
            {
                Console.ReadLine();
                Console.WriteLine("Enter the number is odd");

            }

        }
    }
}
