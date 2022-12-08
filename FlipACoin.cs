using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5PracticeProblem
{
    internal class FlipACoin
    {
        public static void CheckCoinFlip()
        {
            int headcount = 0;
            int tailcount = 0;
            double headpercentage = 0;
            double tailpercentage = 0;
            Console.WriteLine("Enter a value for number of flips");
            int numberOfflip = 2;  //Convert.ToInt32(Console.ReadLine());
            if (numberOfflip > 0)
            {
                for (int i = 0; i < numberOfflip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(0,2);
                    Console.WriteLine(number);
                    if (number == 0)
                    {
                        tailcount++;
                        tailpercentage = tailcount * 100 / numberOfflip;
                        Console.WriteLine("tail pecentage" + tailpercentage);
                    }
                    else
                    {
                        headcount++;
                        headpercentage = headcount * 100 / numberOfflip;
                        Console.WriteLine("head percentage" + headpercentage);
                    }


                }
            }
        } 
    }
}
