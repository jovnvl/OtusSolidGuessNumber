using OtusSolidGuessNumber.Interface;
using OtusSolidGuessNumber.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtusSolidGuessNumber
{
    class GueesValidator: IGuessValidator
    {
        public bool IsValid( int guess, int value, ISetting setting, out string _result) 
        {
            _result = string.Empty;
            bool _isResult = false;
            if (value > setting.Interval.Max || value < setting.Interval.Min)
                _result = $"Число {value} выходит за пределы диапазона от {setting.Interval.Min} до {setting.Interval.Max}";
            else if (value > guess)
                _result = $"Число {value} > отгадываемого";
            else if (value < guess)
                _result = $"Число {value} < отгадываемого";
            else if (value == guess)
            {
                _result = $"Молодец! Ты угадал число {value}";
                _isResult = true;
            }
            return _isResult;
        }
    }
}
