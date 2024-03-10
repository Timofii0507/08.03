using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            var legacyPrinter = new LegacyPrinter();
            var adapter = new PrinterAdapter(legacyPrinter);

            adapter.Print("Hello, world!");
        }
    }
}
