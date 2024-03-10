using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class PrinterAdapter : IAdapter
    {
        private readonly LegacyPrinter _legacyPrinter;

        public PrinterAdapter(LegacyPrinter legacyPrinter)
        {
            _legacyPrinter = legacyPrinter;
        }

        public void Print(string text)
        {
            var lines = text.Split('\n');
            foreach (var line in lines)
            {
                _legacyPrinter.PrintLine(line);
            }
        }
    }
}
