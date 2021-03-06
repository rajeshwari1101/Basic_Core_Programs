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

        //Harmonic Number program
        public static void HarmonicNo()
        {
            float harmonic = 0;
            int n = GetPositiveInt();
            for (int i = 1; i <= n; i++)
                harmonic += (float)1 / (float)i;
            Console.WriteLine("Harmonic no of " + n + ": " + harmonic);
        }

        //Factors Program
        public static void Factors()
        {
            int n = GetPositiveInt();
            bool prime = true;
            Console.WriteLine("The prime factors are: ");
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    prime = true;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = false;
                            break;
                        }
                    }
                    if (prime is true)
                        Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        private static int GetPositiveInt()
        {
            int n = 0;
            do
            {
                Console.Write("Enter a positive integer: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);
            return n;
        }

        //Program to Compute Quotient and Remainder
        public static void QuotientRem()
        {
            int quotient = 0;
            int remainder = 0;
            int dividend = 0;
            int divisor = 0;
            Console.WriteLine("Enter Dividend: ");
            dividend = GetPositiveInt();
            Console.WriteLine("Enter Divisor: ");
            divisor = GetPositiveInt();
            quotient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine("Quotient: " + quotient + " Remainder: " + remainder);
        }

        // Swap 2 numbers
        public static void Swap()
        {
            int a = 0;
            int b = 0;
            int temp = 0;
            Console.WriteLine("Enter value for 'a': ");
            a = GetPositiveInt();
            Console.WriteLine("Enter value for 'b': ");
            b = GetPositiveInt();
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping....");
            Console.WriteLine("a: " + a + " b: " + b);
        }

        //Check Whether a Number is Even or Odd
        public static void OddEven()
        {
            int n = GetPositiveInt();
            if (n % 2 == 0)
                Console.WriteLine("The no is even");
            else
                Console.WriteLine("The no is odd");
        }

        // Checks if alphabet is vowel or consonant
        public static void CheckAphabet()
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            Console.WriteLine("Enter Charcter(a-z/A-Z): ");
            int input = Console.Read();
            char alphabet = Convert.ToChar(input);
            Console.ReadLine();         // To Avoid The unread \n from affecting the other Read/Readline methods
            if ((input >= 65 && input <= 90) || (input >= 97 && input <= 122))
            {
                if (vowels.Contains(alphabet))
                    Console.WriteLine("It is a vowel");
                else
                    Console.WriteLine("It is a consonant");
            }
            else
                Console.WriteLine("Not an Alphabet");
        }


        //Largest Among Three Numbers
        public static void Largest()
        {
            int n1, n2, n3;
            Console.Write("Enter no1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no2: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no3: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
                Console.WriteLine(n1 + " is the largest");
            else if (n2 > n3)
                Console.WriteLine(n2 + " is the largest");
            else
                Console.WriteLine(n3 + " is the largest");
        }
    }

}

