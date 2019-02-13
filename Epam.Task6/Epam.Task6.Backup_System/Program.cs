using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task6.Backup_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Select mode");
                    Console.WriteLine("1 - Watcher");
                    Console.WriteLine("2 - Backup");
                    var mainFolderName = @"Test";
                    var backupFolderName = @"Backup";
                    var pathMain = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, mainFolderName);

                    var pathBack = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, backupFolderName);
                    if (int.TryParse(Console.ReadLine(), out int x))
                    {
                        if (x == 1)
                        {
                            WatcherClass watcher = new WatcherClass(pathMain, pathBack);
                            watcher.StartWatch();
                            Console.WriteLine("Enter \"n\" for exit");
                            while (Console.ReadLine() != "n")
                            {
                            }
                        }

                        if (x == 2)
                        {
                            BackupClass backup = new BackupClass(pathMain, pathBack);
                            //backup.ShowFolders();
                            backup.BackupFolder();
                            Console.WriteLine("Enter \"n\" for exit");
                            while (Console.ReadLine() != "n")
                            {
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
