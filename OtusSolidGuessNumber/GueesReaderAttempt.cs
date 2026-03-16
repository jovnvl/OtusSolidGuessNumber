using OtusSolidGuessNumber.Interface;
using OtusSolidGuessNumber.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber
{
    class GueesReaderAttempt : GueesReaderBase, IGueesReader
    {
        public int Get(Setting setting)
        {
            var _attempt = Ask("Введите количество попыток: ");
            return setting.Attempt = _attempt;
        }
    }
}
