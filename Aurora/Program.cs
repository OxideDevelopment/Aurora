using Aurora.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aurora
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Loading Console handler..");
            ConsoleHandle handle = new ConsoleHandle();
            handle.PrintConsoleInfo();
            handle.Start();
        }
    }
}
