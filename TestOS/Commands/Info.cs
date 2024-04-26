using Cosmos.System.FileSystem;
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

            String q = "CPU Brand" + Cosmos.Core.CPU.GetCPUVendorName() + "\n";
            String cpu = "CPU: " + Cosmos.Core.CPU.GetCPUBrandString() + "\n";
            String mem = Convert.ToString(Cosmos.Core.CPU.GetAmountOfRAM()) + "MB \n";
            String ll = "UpTime: "+ Cosmos.Core.CPU.GetCPUUptime().ToString() + "Sec\n";
            
            //не работает
            //String cpu_freq = Cosmos.Core.CPU.GetCPUCycleSpeed().ToString();
            String info_to_return = cpu + mem + ll + q;
            return info_to_return;
        }
    }
}
