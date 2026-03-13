using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber
{
    internal class Interval :IInterval
    {
        public int Min { get; set; } = 0;
        public int Max { get; set; } = 10;
        public Interval(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }
}
