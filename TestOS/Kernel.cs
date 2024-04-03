using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Threading;
using TestOS.Commands;

namespace TestOS
{
    public class Kernel : Sys.Kernel
    {
        private ComManager ComManager;
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("Booted successfully.");
            this.ComManager = new ComManager();

        }

        protected override void Run()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write("~ ");

            String input;
            input = this.ComManager.proccesInput(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(input);
            Console.ResetColor();
        }
    }
}
