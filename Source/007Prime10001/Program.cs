using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007Prime10001
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            var total = FirstMethod(1);
            stopWatch.Stop();

            var ts = stopWatch.Elapsed;
            var elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            ts.Hours, ts.Minutes, ts.Seconds,
                                            ts.Milliseconds / 10);

            Console.WriteLine("First Method answer is: " + total + " (calculated in " + elapsedTime + " )");

            Console.ReadLine();
        }

        public static long FirstMethod(int nth)
        {
            IList<int> primes = new List<int>();

            primes.Add(2);

            var c = 1;
            var start = 3;

            if (nth > 1)
            {
                while (true)
                {
                    var startSqRoot = start*start;
                    for (int i = 1; i < c && primes[i] <= startSqRoot; i++)
                    {
                        if (start%primes[i] == 0)
                        {

                        }
                    }
                    /*
                     for ($i = 1; $i < $c && $primes[$i] <= $sqrt; $i++) {
            if ($p % $primes[$i] == 0) {
                $prime = false;
                break;
            }
        }
                     */
                }
            }

            return primes[nth - 1];
        }
    }
}
