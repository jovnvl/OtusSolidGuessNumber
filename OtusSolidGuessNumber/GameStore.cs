using OtusSolidGuessNumber.Interface;
using OtusSolidGuessNumber.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OtusSolidGuessNumber
{
    class GameStore
    {
        public GueesReader Reader { get; set; }
        public IGueesReaderInterval ReaderInterval { get; set; }
        public IGuessValidator Validator { get; set; }
        public IGueesGenerate Generate {  get; set; }
        public GameStore(GueesReader reader, IGueesReaderInterval readerInterval, IGuessValidator validator, IGueesGenerate generate)
        {
            Reader = reader;
            Validator = validator;
            Generate = generate;
            ReaderInterval = readerInterval;
        }
        public void Executor()
        {
            var _attempt = Reader.Get(new GueesReaderAttempt());
            var _interval = ReaderInterval.Get(Reader.Setting.Interval);
            int _guessNumber = Generate.GenerationValue(_interval.Min, _interval.Max);
            var _res = GameProcess(_attempt, _guessNumber, Reader.Setting);
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

                var _number = Reader.Get(new GueesReaderNumber());

                _result = Validator.IsValid(guessValue, _number, setting, out string currentRes);
                Console.WriteLine(currentRes);
            }
            return _result ? $"Поздравляем, попыток - {_currentAttempt}!" : $"Не угадал, попыток - {_currentAttempt}, это число " + guessValue + ".";
        }
    }
}