using System;
using System.Text;

namespace ModernMedical
{
    /// <summary>
    /// Demo program for Modern Medical
    /// 
    /// a. Have the program go through the numbers 1 to 100 (inclusive)
    /// b. If the number is divisible by 3 only, output Modern
    /// c. If the number is divisible by 5 only, output Medical
    ///d. If the number is divisible by both 3 and 5, output ModernMedical
    ///e. If the number is not divisible by either 3 or 5, only output the number itself.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            for (int i = 1; i < 101; i++)
            {
                a = 0;
                b = 0;

                //Console.WriteLine("i={0}", i);

                a = i % 3;
                //Console.WriteLine("a={0}", a);

                if (a == 0)
                {
                    Console.WriteLine("Modern", i);
                }
                b = i % 5;

                if (b == 0)
                {
                    Console.WriteLine("Medical", i);
                }

                if (a == 00 && b == 0)
                {
                    Console.WriteLine("ModernMedical",i);
                }
                else if (a != 00 && b != 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Press the enter key to exit the console session");
            Console.ReadLine();
        }

    }
}

