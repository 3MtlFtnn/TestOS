using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Threading;
using TestOS.Commands;
using Cosmos.System.FileSystem;

namespace TestOS
{
    public class Kernel : Sys.Kernel
    {
        private ComManager ComManager;
        private CosmosVFS vfs;
       
        protected override void BeforeRun()
        {
            this.vfs = new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.vfs);
            Console.Clear();
            Console.WriteLine("Booted successfully.");
            this.ComManager = new ComManager();
            /*
            var available_space = vfs.GetAvailableFreeSpace(@"0:\");
            var fs_type = vfs.GetFileSystemType(@"0:\");
            Console.WriteLine("File System Type: " + fs_type);
            Console.WriteLine("Available Free Space: " + available_space);
            */
            
        }

        protected override void Run()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write("~ ");

            String input;
            input = this.ComManager.proccesInput(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(input);
            Console.ResetColor();
        }
    }
}
