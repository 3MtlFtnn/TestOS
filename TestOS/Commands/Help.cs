using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOS.Commands
{
    public class Help : Command
    {
        public Help (String name) : base (name) { }

        public override String run(string[] args)
        {
            return "This it help command! Hello, this system basically do nothing :) ";
        }
    }
}
