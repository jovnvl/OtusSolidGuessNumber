using OtusSolidGuessNumber.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber.Interface
{
    internal interface ISetting
    {
        public int Attempt { get; set; }
        public Interval Interval { get; set; }
    }
}
