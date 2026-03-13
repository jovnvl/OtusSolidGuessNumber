using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber
{
    interface IGueesReader
    {
        Setting Setting { get;}
        int Number { get;}
        int GetAttempt();
        Setting GetInterval();
        int GetNumber();
    }
}
