using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Threading;
using TestOS.Commands;
using Cosmos.System.FileSystem;
using System.IO;

namespace TestOS
{
    public class Kernel : Sys.Kernel
    {
        private ComManager ComManager;
        private CosmosVFS vfs;
        string cur_dir = @"0:\";


        protected override void BeforeRun()
        {


            this.vfs = new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.vfs);
            vfs.Initialize(true);
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
        //private string[] GetDirFadr(string adr) // get directories From address
        //{

           // string dirs = Directory.GetCurrentDirectory();

            //return dirs;

        //}

        protected override void Run()
        {
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            //string[] dirs = Directory.(cur_dir);
            string dirs = Directory.GetDirectoryRoot(cur_dir);
            Console.Write(dirs + "> ");
            
            String input;
            input = this.ComManager.proccesInput(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(input);
            Console.ResetColor();
        }
    }
}
