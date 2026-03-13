using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber
{
    class Setting : ISetting
    {
        public Interval Interval { get; set; }
        public int Attempt { get; set; }
        public Setting() 
        {
            Attempt = 0;
            Interval = new Interval(0, 10);
        }
    }
}
