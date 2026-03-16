using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber.Interface
{
    interface IGueesGenerate
    {
        int GenerationValue(int maxValue);
        int GenerationValue(int minValue, int maxValue);
    }
}
