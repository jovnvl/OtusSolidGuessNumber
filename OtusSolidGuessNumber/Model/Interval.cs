using OtusSolidGuessNumber.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber.Model
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
        public Interval() { Min = 0; Max = 0; }
    }
}
