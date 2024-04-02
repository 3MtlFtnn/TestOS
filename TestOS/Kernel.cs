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
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
            this.ComManager = new ComManager();

        }

        protected override void Run()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write("Input: ");

            String input;
            input = this.ComManager.proccesInput(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(input);
            Console.ResetColor();
            

        }
    }
}
