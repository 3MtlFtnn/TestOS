using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOS.Commands
{
    internal class Reboot : Command
    {
        public Reboot(String name) : base (name){ }

        public override String run(string[] args)
        {
            Cosmos.System.Power.Reboot();
            return "";

        }
    }
}
