using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOS.Commands
{
    internal class PowerOff : Command
    {
        public PowerOff(String name) : base(name) { }

        public override String run(string[] args)
        {
            Cosmos.System.Power.Shutdown();
            return "";
        }
    }
}

