using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber
{
    class GueesGenerate : IGueesGenerate
    {
        Random _rnd = new();
        public int GenerationValue(int minValue, int maxValue)
        {
            int _value = _rnd.Next(minValue ,maxValue + 1);
            return _value;
        }

        public int GenerationValue(int maxValue)
        {
            int _value = _rnd.Next(maxValue + 1);
            return _value;
        }
    }
}
