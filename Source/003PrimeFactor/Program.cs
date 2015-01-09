using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _000Common;

namespace PrimeFactor
{
    class Program
    {

        static void Main(string[] args)
        {
            const long number = 600851475143;

            var stopWatch = new Stopwatch();

            stopWatch.Start();
            var total = FirstMethod(number);
            stopWatch.Stop();

            var ts = stopWatch.Elapsed;
            var elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            ts.Hours, ts.Minutes, ts.Seconds,
                                            ts.Milliseconds / 10);

            Console.WriteLine("First method answer is: " + total + " (calculated in " + elapsedTime + " )");

            Console.ReadLine();
        }

        public static long FirstMethod(long number)
        {
            long current = 2;

            while (number > current)
            {
                if (number % current == 0)
                {
                    number = number / current;
                    current = 2;
                }
                else
                {
                    current++;
                }
            }

            return current;
        }
    }
}
