using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5PracticeProblem
{
    internal class ComputeQandR
    {
        public static void CheckQuotientRemainder()
        {

            int dividend = 50, divisor = 5;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend : {0} Divisor : {1}", dividend, divisor);

            Console.WriteLine("Dividend : " + dividend + " Divisor : " + divisor);

            Console.WriteLine("Quotient : " + quotient);

            Console.WriteLine("Remainder : " + remainder);

        }
    }
}
