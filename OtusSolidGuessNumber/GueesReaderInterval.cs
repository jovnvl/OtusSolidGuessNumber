using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber
{
    internal class GueesReaderInterval : GueesReaderBase, IGueesReaderInterval
    {
        public Interval Get(Interval interval)
        {
            var _minNumber = Ask($"Выберите минимальное число для диапазона чисел, начиная с 0: ");
            interval.Min = _minNumber;
            var _maxNumber = Ask($"Выберите максимальное число для диапазона чисел, начиная с {interval.Min}: ");
            interval.Max = _maxNumber;
            return interval;
        }
    }
}
