using System;
using System.Linq;

namespace Abletech.ArxMetric.Calculators
{
    public static class TimeCalculator
    {
        public static TimeCalculateResult EvaluateTime(double[] timeMs)
        {
            //Exclude the first element
            var times = timeMs.Skip(1).Take(timeMs.Length - 1).ToArray();

            var result = new TimeCalculateResult
            {
                Average = GetAverage(times),
                StandardDeviation = GetStandardDeviation(times),
                Min = timeMs.Min(),
                Max = times.Max(),
            };
            return result;
        }
        private static double GetStandardDeviation(double[] timeMs)
        {
            if (timeMs.Length > 1)
            {
                double avg = GetAverage(timeMs);
                double sumOfSquares = 0.0;

                foreach (int num in timeMs)
                {
                    sumOfSquares += Math.Pow((num - avg), 2.0);
                }

                return Math.Sqrt(sumOfSquares / (double)(timeMs.Length));
            }
            else { return 0.0; }
        }

        private static double GetAverage(double[] timeMs)
        {
            int sum = 0;

            if (timeMs.Length > 1)
            {
                foreach (int num in timeMs)
                {
                    sum += num;
                }
                return sum / (double)timeMs.Length;
            }
            return (double)timeMs[0];
        }
    }
}
