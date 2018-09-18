using System;

namespace Abletech.ArxMetric.Calculators
{
    public class TimeCalculateResult
    {
        public double Average { get; set; }
        public double StandardDeviation { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }

        public override string ToString()
        {
            return string.Format("Average: {0}\r\nStandardDeviation: {1}\r\nMin: {2}\r\nMax: {3}\r\n",
                Average, StandardDeviation, Min, Max);
        }
    }
}