using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOS.Commands
{
    public class ComManager
    {
        private List<Command> commands;

        public ComManager() { 
            this.commands = new List<Command>();
            this.commands.Add(new Help("/help"));
            this.commands.Add(new Info("/info"));
            this.commands.Add(new PowerOff("/poweroff"));
            this.commands.Add(new Reboot("/reboot"));
            this.commands.Add(new File("/file"));
            
        }

        public String proccesInput (String input)
        {
            String[] split = input.Split(' ');
            
            String task = split[0];

            List<String> args = new List<String>();

            int count = 0;
            foreach(String s in split)
            {
                if (count != 0)
                {
                    args.Add(s);
                }
                count++;
            }

            foreach(Command cmd in this.commands)
            {
                if (cmd.name == task) { return cmd.run(args.ToArray()); }
            }

            return "Unknown command: "+task;
        }
    }
}
