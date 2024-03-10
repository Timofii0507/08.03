using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class LegacyPrinter
    {
        public void PrintLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
