using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OtusSolidGuessNumber
{
    class GueesReader : GueesReaderBase
    {
        public Setting Setting { get;}
        public int Number { get; set; }
        public GueesReader() { Setting = new Setting(); }
        public int Get(IGueesReader gueesReader)
        {
            Number = gueesReader.Get(Setting);
            return Number;
        }
    }
}