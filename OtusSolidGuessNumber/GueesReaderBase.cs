
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OtusSolidGuessNumber
{
    class GueesReaderBase : IGuessReaderBase
    {
        public int Ask(string message)
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