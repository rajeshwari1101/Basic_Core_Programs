using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class BasicPrograms
    {

        //Flip Coin and print percentage of Heads and Tails

        static Random random = new Random();

        public static void FlipCoin()
        {
            int count = 0;
            int headCount = 0;
            int tailCount = 0;
            float headPercent = 0;
            float tailPercent = 0;
            double toss = 0;

            do
            {
                Console.Write("Enter a positive integer: ");
                count = Convert.ToInt32(Console.ReadLine());
            } while (count < 0);
            for (int i = 0; i < count; i++)
            {
                toss = random.NextDouble();
                if (toss < 0.5)
                    headCount++;
                else
                    tailCount++;
            }
            headPercent = (float)headCount / (float)(headCount + tailCount);
            tailPercent = (float)tailCount / (float)(tailCount + headCount);
            Console.WriteLine("Head count: " + headCount + " Head Percent: " + headPercent);
            Console.WriteLine("Tail count: " + tailCount + " Tail Percent: " + tailPercent);
        }

        //Leap Year Program

        public static void LeapYear()
        {
            int year = 0;
            do
            {
                Console.Write("Enter a year(yyyy): ");
                year = Convert.ToInt32(Console.ReadLine());
            } while (year / 1000 == 0);
            if (year % 4 == 0)
                Console.WriteLine("It is a leap year");
            else
                Console.WriteLine("It is not a leap year");
        }

        //Power of 2 program
        public static void Power2(int n)
        {
            int pow2 = 0;
            while (n < 0 || n > 30)
            {
                Console.Write("Enter a n(0-30): ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= n; i++)
            {
                pow2 = Convert.ToInt32(Math.Pow(2, i));
                Console.WriteLine("2^" + i + " = " + pow2);
            }
        }

    }

}

