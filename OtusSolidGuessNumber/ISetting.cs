using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber
{
    internal interface ISetting
    {
        public int Attempt { get; set; }
        public Interval Interval { get; set; }
    }
}
