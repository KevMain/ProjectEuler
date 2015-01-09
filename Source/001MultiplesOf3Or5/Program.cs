using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MultiplesOf3Or5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int totalNum = 1000;

            var stopWatch = new Stopwatch();

            stopWatch.Start();
            var total = FirstMethod(totalNum);
            stopWatch.Stop();

            var ts = stopWatch.Elapsed;
            var elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            ts.Hours, ts.Minutes, ts.Seconds,
                                            ts.Milliseconds / 10);

            Console.WriteLine("First method answer is: " + total + " (calculated in " + elapsedTime + " )");

            stopWatch.Reset();

            stopWatch.Start();
            var total2 = SecondMethod(totalNum);
            stopWatch.Stop();

            var ts2 = stopWatch.Elapsed;
            var elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            ts2.Hours, ts2.Minutes, ts2.Seconds,
                                            ts2.Milliseconds / 10);

            Console.WriteLine("Second Method answer is: " + total2 + " (calculated in " + elapsedTime2 + " )");

            Console.ReadLine();
        }

        public static long FirstMethod(int totalNum)
        {
            var multipliers = new List<Multiplier> { new Multiplier(3), new Multiplier(5) };

            IList<long> matchingNumbers = new List<long>();

            const long startingValue = 1;
            long maxValue = totalNum;

            for (var i = startingValue; i < maxValue; i++)
            {
                if (multipliers.Any(multiplier => i % multiplier.GetNumber() == 0))
                {
                    matchingNumbers.Add(i);
                }
            }

            return matchingNumbers.Aggregate<long, long>(0, (current, matchingNumber) => current + matchingNumber);
       }

        public static long SecondMethod(int totalNum)
        {
            long a = (totalNum - 1) / 3; 
            long b = (totalNum - 1) / 5; 
            long c = (totalNum - 1) / 15; 
            long d = a * (a + 1) / 2;
            long e = b * (b + 1) / 2;
            long f = c * (c + 1) / 2;

            return 3 * d + 5 * e - 15 * f;
        }
    }
}
