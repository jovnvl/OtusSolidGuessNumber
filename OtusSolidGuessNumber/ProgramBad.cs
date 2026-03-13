namespace OtusSolidGuessNumber
{
    class ProgramBad
    {
        static Random rnd = new Random();
        static Setting setting = new Setting();
        static void Rules()
        {
            //правила игры
            var attemp = AskUser("Введите количество попыток: ");
            setting.Attempt = attemp;
            var maxNumber = AskUser("Выберите максимальное число для интервала чисел от 0: ");
            setting.Interval = new Interval(0, maxNumber);
        }
        static int GenerationValue(int maxValue)
        {
            int value = rnd.Next(maxValue);
            return value;
        }
        static string GameProcess(int attempts, int guessValue, int maxValue)
        {
            var currentAttempt = 0; //счетчик количества попыток
            while (attempts > 0 && currentAttempt < attempts)
            {
                currentAttempt++;
                Console.Write($"Попытка {currentAttempt}.");
                var entNumber = AskUser($" Введите число от 0 до { maxValue}: ");
            
                if (entNumber > maxValue || entNumber < 0)
                    Console.WriteLine($"Попытка {currentAttempt}. Число {entNumber} выходит за пределы диапазона от 0 до {maxValue}");
                else if (entNumber > guessValue)
                    Console.WriteLine($"Попытка {currentAttempt}. Число {entNumber} > отгадываемого");
                else if (entNumber < guessValue)
                    Console.WriteLine($"Попытка {currentAttempt}. Число {entNumber} < отгадываемого");
                else if (entNumber == guessValue)
                    return "Молодец! Ты угадал с " + currentAttempt + " попытки.";
            }
            return "Не угадал, это число " + guessValue + ".";
        }
        static int AskUser(string message)
        {
            Console.WriteLine(message);
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                    return result;

                Console.WriteLine("Не является числом!");
            }
        }
        static void MainBad(string[] args)
        {
            Console.Title = "Угадай число";
            Console.WriteLine("Угадай число");
            Rules();//настройки

            int guessNumber = GenerationValue(setting.Interval.Max);
            var result = GameProcess(setting.Attempt, guessNumber, setting.Interval.Max);
            Console.WriteLine(result);
            Console.ReadKey();
            /*
            int result1 = DoOperation(6, DoubleNumber); // 12
            Console.WriteLine(result1);

            int result2 = DoOperation(6, SquareNumber); // 36
            Console.WriteLine(result2);

            int DoOperation(int n, Func<int, int> operation) => operation(n);
            int DoubleNumber(int n) => 2 * n;
            int SquareNumber(int n) => n * n;
            */
        }
    }
}
