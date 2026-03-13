using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber
{
    interface IGuessValidator
    {
        bool IsValid(int guess, int value, Setting setting, out string result);
    }
}
