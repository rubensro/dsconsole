using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDeamonService
{



    class Program
    {




        private static void MonitorDirectory(string path)
        {
            var fileSystemWatcher = new FileSystemWatcher();
            fileSystemWatcher.Path = path;
            fileSystemWatcher.Created += FileSystemWatcher_Created;
            fileSystemWatcher.Renamed += FileSystemWatcher_Renamed;
            fileSystemWatcher.Deleted += FileSystemWatcher_Deleted;
            fileSystemWatcher.EnableRaisingEvents = true;

    
            /* REQUIERE ADMIN
            string eventSourceName = "MDConsoleApp";
            string logName = "MonitorFiles";
          
            var eventLog1 = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists(eventSourceName))
            {
                System.Diagnostics.EventLog.CreateEventSource(eventSourceName, logName);
            }
            eventLog1.Source = eventSourceName;
            eventLog1.Log = logName;

            eventLog1.WriteEntry("Iniciando Programa...");
            */
        }

        private static void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            
            Console.WriteLine("File Created: {0}", e.Name);
        }

        private static void FileSystemWatcher_Renamed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File Renamed: {0}", e.Name);
        }

        private static void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File Deleted: {0}", e.Name);
        }


        static void Main(string[] args)
        {

            var path = @"C:\Directory";
            MonitorDirectory(path);
            Console.ReadKey();


        }
    }
}
