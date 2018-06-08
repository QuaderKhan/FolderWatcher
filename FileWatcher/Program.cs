using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolderWatcher.Handlers;

namespace FolderWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var watcher = new FileSystemWatcher(@"D:\Temp");

            watcher.EnableRaisingEvents = true;
            
            watcher.Created += FileCreatedhandler.File_Created;

            watcher.Deleted += FileDeletedHandler.File_Deleted;

            watcher.Renamed += FileRenamedHandler.File_Renamed;

            //watcher.Changed

            Console.ReadKey(true);

        }

       

       


    }
}
