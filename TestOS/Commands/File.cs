using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Sys = Cosmos.System;

namespace TestOS.Commands
{
    internal class File : Command
    {
        public File (String name) : base (name) { }

        public override String run (string[] args)
        {
            String return_ = "";
            switch (args[0])
            {
                case "create":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateFile(args[1]);
                        return_ = $@"file {args[1]} created";
                    }
                    catch (Exception e)
                    { 
                        return_ = e.ToString();
                        break;
                    }
                    
                    break;
                case "delete":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.DeleteFile(args[1]);
                        return_ = $@"file {args[1]} removed";
                    }
                    catch (Exception e)
                    {
                        return_ = e.ToString();
                        break;
                    }

                    break;
                case "mkdir":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateDirectory(args[1]);
                        return_ = $@"directory {args[1]} created";
                    }
                    catch (Exception e)
                    {
                        return_ = e.ToString();
                        break;
                    }
                    break;
                case "rmdir":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.DeleteDirectory(args[1],true);
                        return_ = $@"directory {args[1]} removed";
                    }
                    catch (Exception e)
                    {
                        return_ = e.ToString();
                        break;
                    }
                    break;
                case "ls":
                    try
                    {
                        //String list_file = Directory.
                    }
                    catch (Exception e)
                    {
                        return_ = e.ToString();
                        break;
                    }
                    break;
                case "wi":
                    try
                    {
                        FileStream fs =(FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(args[1]).GetFileStream();

                        if (fs.CanWrite)
                        {
                            Byte[] data = Encoding.ASCII.GetBytes(args[2]);
                            fs.Write(data, 0, data.Length);
                            fs.Close();
                            return_ = "Writed in file succses!";
                        }else
                        {
                            return_ = "denied!";
                            break;
                        }
                    }
                    catch(Exception e) { return_ = e.ToString();}
                    break;
                case "ro":
                    try
                    {
                        FileStream fs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(args[1]).GetFileStream();

                        if (fs.CanRead)
                        {
                            Byte[] data = new Byte[256];
                            fs.Read(data, 0, data.Length);
                            return_=Encoding.ASCII.GetString(data);
                            
                        }
                        else
                        {
                            return_ = "denied!";
                            break;
                        }
                    }
                    catch (Exception e) { return_ = e.ToString(); }
                    break;


                default:
                    return_ = @$"Unknown {args[0]} function";
                    break;
            }

            return return_;
        }

    }
}
