using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OtusSolidGuessNumber
{
    class GameStore
    {
        public IGueesReader Reader { get; set; }
        public IGuessValidator Validator { get; set; }
        public IGueesGenerate Generate {  get; set; }
        public GameStore(IGueesReader reader, IGuessValidator validator, IGueesGenerate generate)
        {
            Reader = reader;
            Validator = validator;
            Generate = generate;
        }
        public void Executor()
        {
            var _attempt = Reader.GetAttempt();
            var _setting = Reader.GetInterval();
            int _guessNumber = Generate.GenerationValue(_setting.Interval.Min, _setting.Interval.Max);
            var _res = GameProcess(_attempt, _guessNumber, _setting);
            Console.WriteLine(_res);
            Console.ReadKey();
        }
        private string GameProcess(int attempt, int guessValue, Setting setting)
        {
            Console.Title = "Угадай число";
            Console.WriteLine("Угадай число");
            var _currentAttempt = 0; //счетчик количества попыток
            var _result = false;
            while (!_result && attempt > 0 && _currentAttempt < attempt)
            {
                _currentAttempt++;
                Console.Write($"Попытка {_currentAttempt}.");

                var _number = Reader.GetNumber();

                _result = Validator.IsValid(guessValue, _number, setting, out string currentRes);
                Console.WriteLine(currentRes);
            }
            return _result ? $"Поздравляем, попыток - {_currentAttempt}!" : $"Не угадал, попыток - {_currentAttempt}, это число " + guessValue + ".";
        }
    }
}