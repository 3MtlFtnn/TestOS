﻿using Cosmos.System.FileSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOS.Commands
{
    public class Info : Command
    {
        public Info (String name) : base (name) { }
        private ComManager ComManager;
        private CosmosVFS vfs;
        public override String run(String[] args)
        {  
            
            String cpu = "CPU: " + Cosmos.Core.CPU.GetCPUBrandString() + "\n";
            String mem = Convert.ToString(Cosmos.Core.CPU.GetAmountOfRAM()) + "MB \n";
            String info_to_return = cpu + mem;
            return info_to_return;
        }
    }
}
