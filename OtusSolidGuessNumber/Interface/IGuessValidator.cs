using OtusSolidGuessNumber.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber.Interface
{
    interface IGuessValidator
    {
        bool IsValid(int guess, int value, Setting setting, out string result);
    }
}
