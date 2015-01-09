using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            var total = FirstMethod();
            stopWatch.Stop();

            var ts = stopWatch.Elapsed;
            var elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            ts.Hours, ts.Minutes, ts.Seconds,
                                            ts.Milliseconds / 10);

            Console.WriteLine("First Method answer is: " + total + " (calculated in " + elapsedTime + " )");

            Console.ReadLine();
        }

        public static bool IsPalindromic(long num)
        {
            var left = num;
            long rev = 0;
            while (left > 0)
            {
                var r = left % 10;
                rev = rev * 10 + r;
                left = left / 10; 
            }

            return num == rev;
        }

        public static long FirstMethod()
        {
            long highestPalindromic = 0;

            for (long i = 999; i > 100; i--)
            {
                for (long j = 999; j > 100; j--)
                {
                    var v = i*j;
                    if (v > highestPalindromic)
                    {
                        if (IsPalindromic(v))
                            highestPalindromic = v;
                    }
                }               
            }

            return highestPalindromic;
        }
    }
}
