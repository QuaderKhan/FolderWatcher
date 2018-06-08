using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderWatcher.Handlers
{
    public class FileDeletedHandler
    {
        public static void File_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File {0} is {1}", e.Name, e.ChangeType);

        }
    }
}
