using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005SmallestMultiple
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
            var smallestNum = 0;
            var currentNum = 1;

            while (smallestNum <= 0)
            {
                for (var i = 1; i <= 20; i++)
                {
                    if (currentNum%i != 0)
                        break;
                    
                    if(i == 20)
                    {
                        smallestNum = currentNum;
                    }
                }
                currentNum++;
            }

            return smallestNum;
        }
    }
}
