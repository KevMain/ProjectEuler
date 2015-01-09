using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006SumSquareDifference
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

        public static long FirstMethod()
        {
            var sumOfSquare = 0;
            var squareOfTheSum = 0;
            for (var i = 1; i <= 100; i++)
            {
                sumOfSquare = sumOfSquare + (i * i);
                squareOfTheSum = squareOfTheSum + i;
            }

            squareOfTheSum = squareOfTheSum*squareOfTheSum;

            return squareOfTheSum - sumOfSquare;
        }
    }
}
