using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOS.Commands
{
    internal class Clear : Command
    {
        public Clear(String name) : base(name) { }

        public override String run(string[] args)
        {
            Console.Clear();
            return "";
        }
    }
}
