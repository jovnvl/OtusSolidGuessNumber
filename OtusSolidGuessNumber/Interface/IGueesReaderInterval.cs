using OtusSolidGuessNumber.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber.Interface
{
    interface IGueesReaderInterval
    {
        Interval Get(Interval interval);
    }
}
