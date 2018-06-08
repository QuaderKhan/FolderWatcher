using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderWatcher.Handlers
{
    public class FileRenamedHandler
    {
        public static void File_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("{0} : {1} to {2}", e.OldName, e.ChangeType, e.Name);
        }
    }
}
