using OtusSolidGuessNumber.Interface;
using OtusSolidGuessNumber.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber
{
    class GueesReaderNumber : GueesReaderBase, IGueesReader
    {
        public int Number { get; set; }
        public int Get(Setting setting)
        {
            Number = Ask($" Введите число от {setting.Interval.Min} до {setting.Interval.Max}: ");
            return Number;
        }
    }
}
