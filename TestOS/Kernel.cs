using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Sys = Cosmos.System;
using System.Threading;

namespace TestOS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");

        }

        protected override void Run()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Input: ");

            var input = Console.ReadLine();
            switch (input)
            {
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(input + ": Check command");
                    Console.ResetColor();

                    break;
                case "/help":
                    Console.WriteLine("Hello, this is test OS!");
                    Console.WriteLine("'poweroff' - shutdown PC");
                    Console.WriteLine("'clear' - cleaning terminal");
                    Console.WriteLine("'info' - show system info");
                    break;
                case "poweroff":
                    for (int i = 3; i>0; i--)
                    {
                        Console.WriteLine("System will by shutdown by "+i);
                        Thread.Sleep(1000);

                    }
                 
                    Sys.Power.Shutdown();
                    break;
                case "clear":
                    Console.Clear();
                    break;
                case "info":
                    string cpu_name = Cosmos.Core.CPU.GetCPUBrandString();
                    uint ram_cap = Cosmos.Core.CPU.GetAmountOfRAM();

                    Console.WriteLine("     _________                                         \r\n    / ======= \\                                        \r\n   / __________\\                                       \r\n  | ___________ |                                      \r\n  | | -       | |                                      \r\n  | |         | |                                      \r\n  | |_________| |________________________              \r\n  \\=____________/   OS on C#? Yes!     )               \r\n  / \"\"\"\"\"\"\"\"\"\"\" \\                       /              \r\n / ::::::::::::: \\                  =D-'               \r\n(_________________)                                    \r\n                                                       ");
                    Console.WriteLine("CPU: "+ cpu_name);
                    Console.WriteLine("MEM: " + (ram_cap) + "MB");
                    break;

            }
            
        }
    }
}
