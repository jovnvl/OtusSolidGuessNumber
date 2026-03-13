using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OtusSolidGuessNumber
{
    class GueesReader : IGueesReader
    {
        public Setting Setting { get;}
        public int Number { get;}
        public GueesReader() { Setting = new Setting(); }
        public int GetAttempt()
        {
            var _attempt = Ask("Введите количество попыток: ");
            return Setting.Attempt = _attempt;
        }

        public Setting GetInterval()
        {
            var _minNumber = Ask($"Выберите минимальное число для диапазона чисел, начиная с 0: ");
            Setting.Interval.Min =_minNumber;
            var _maxNumber = Ask($"Выберите максимальное число для диапазона чисел, начиная с {_minNumber}: ");
            Setting.Interval.Max = _maxNumber;
            return Setting;
        }

        public int GetNumber()
        {
            var _number = Ask($" Введите число от {Setting.Interval.Min} до {Setting.Interval.Max}: ");
            return _number;
        }

        private int Ask(string message)
        {
            Console.WriteLine(message);
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                    return result;

                Console.WriteLine("Не является числом!");
            }
        }
    }
}