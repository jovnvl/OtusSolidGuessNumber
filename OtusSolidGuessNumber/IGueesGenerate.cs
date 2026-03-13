using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber
{
    interface IGueesGenerate
    {
        int GenerationValue(int maxValue);
        int GenerationValue(int minValue, int maxValue);
    }
}
