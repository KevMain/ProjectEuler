using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            var seq = FirstMethod();
            stopWatch.Stop();

            var ts = stopWatch.Elapsed;
            var elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            ts.Hours, ts.Minutes, ts.Seconds,
                                            ts.Milliseconds / 10);

            var total = 0;
            foreach (var number in seq)
            {
                if (number%2 == 0)
                {
                    total = total + number;
                }
            }

            Console.WriteLine("First method answer is: " + total + " (calculated in " + elapsedTime + " )");

            Console.ReadLine();
        }

        public static IList<int> FirstMethod()
        {
            IList<int> numbers = new List<int>();

            var firstNum = 1;
            var secondNum = 2;

            numbers.Add(firstNum);
            numbers.Add(secondNum);

            var nextNum = 0;
            while (nextNum < 4000001)
            {
                nextNum = NextNumber(firstNum, secondNum);
                if(nextNum > 4000000)
                    break;
                
                numbers.Add(nextNum);

                firstNum = secondNum;
                secondNum = nextNum;
            }

            return numbers;
        }

        public static int NextNumber(int first, int second)
        {
            return first + second;
        }

    }
}
