using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
string cpu_name = Cosmos.Core.CPU.GetCPUBrandString();
uint ram_cap = Cosmos.Core.CPU.GetAmountOfRAM();

Console.WriteLine("     _________                                         \r\n    / ======= \\                                        \r\n   / __________\\                                       \r\n  | ___________ |                                      \r\n  | | -       | |                                      \r\n  | |         | |                                      \r\n  | |_________| |________________________              \r\n  \\=____________/   OS on C#? Yes!     )               \r\n  / \"\"\"\"\"\"\"\"\"\"\" \\                       /              \r\n / ::::::::::::: \\                  =D-'               \r\n(_________________)                                    \r\n                                                       ");
Console.WriteLine("CPU: " + cpu_name);
Console.WriteLine("MEM: " + (ram_cap) + "MB");
break;
*/
namespace TestOS.Commands
{
    public class Info : Command
    {
        public Info (String name) : base (name) { }

        public override String run(String[] args)
        {
            String info = "CPU: "+ Cosmos.Core.CPU.GetCPUBrandString() + "\n";
            info += "MEM: "+ Cosmos.Core.CPU.GetAmountOfRAM() + "MB \n";

            return info;
        }
    }
}
