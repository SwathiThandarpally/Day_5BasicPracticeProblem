using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5PracticeProblem
{
    internal class FindLargestNum
    {
        public static void CheckLargestNumber()
        {
            Console.WriteLine("Find the largest numbers");

            Console.WriteLine("Input the first number");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());



            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The first number is greatest among three");
                }
                else
                {
                    Console.WriteLine("The third number is greatest among three");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The second number is greatest among three");

            }
            else
            {
                Console.WriteLine("The third number is greatest among three");
            }

        }
    }
}
