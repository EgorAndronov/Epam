using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task6.Backup_System
{
    public class WatcherClass
    {
        private FileSystemWatcher watcher = new FileSystemWatcher();

        private DirectoryInfo backup;
        private DirectoryInfo folder;
         
        public WatcherClass()
        {
        }

        public WatcherClass(string pathMain, string pathBackup)
        {
            this.folder = new DirectoryInfo(pathMain);
            this.backup = new DirectoryInfo(pathBackup);           
        }

        public void StartWatch()
        {
            if (!this.backup.Exists)
            {
                this.backup.Create();
            }

            Console.WriteLine(this.folder.FullName);
            Console.WriteLine(this.backup.FullName);

            this.watcher.Path = this.folder.FullName;
            this.watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            this.watcher.Filter = "*.txt";
            this.watcher.Created += new FileSystemEventHandler(this.FunCreate);
            this.watcher.Changed += new FileSystemEventHandler(this.FunChange);
            this.watcher.Deleted += new FileSystemEventHandler(this.FunDelete);
            this.watcher.Renamed += new RenamedEventHandler(this.FunRename);

            this.watcher.EnableRaisingEvents = true;
        }

        public void CreateBackup(FileSystemEventArgs e, string status)
        {
            FileInfo file = new FileInfo(e.FullPath);
            string fileName = string.Format($"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}({DateTime.Now.Hour}h {DateTime.Now.Minute}m {DateTime.Now.Second}s)");
            var backupPath = Path.Combine(this.backup.FullName, string.Format($"Backup { fileName }"));
            var backupFolder = new DirectoryInfo(backupPath);
            backupFolder.Create();
            string fileBackName = string.Format($"{status}{e.Name}");
            var fileBackPath = Path.Combine(backupPath, fileBackName);
            file.CopyTo(fileBackPath);
        }

        public void FunCreate(object sender, FileSystemEventArgs e)
        {
            try
            {
                this.watcher.EnableRaisingEvents = false;
            }
            finally
            {
                this.watcher.EnableRaisingEvents = true;
                Console.WriteLine($"Файл {e.FullPath} добавлен");
                this.CreateBackup(e, "(create)");
            }
        }

        public void FunChange(object sender, FileSystemEventArgs e)
        {
            try
            {
                Thread.Sleep(1000);
                this.watcher.EnableRaisingEvents = false;
            }
            finally
            {
                this.watcher.EnableRaisingEvents = true;
                Console.WriteLine($"Файл {e.FullPath} изменен");
                this.CreateBackup(e, "(change)");
            }
        }

        public void FunDelete(object sender, FileSystemEventArgs e)
        {
            try
            {
                this.watcher.EnableRaisingEvents = false;
            }
            finally
            {
                this.watcher.EnableRaisingEvents = true;
                Console.WriteLine($"Файл {e.FullPath} удален");
            }
        }

        public void FunRename(object sender, FileSystemEventArgs e)
        {
            try
            {
                this.watcher.EnableRaisingEvents = false;
            }
            finally
            {
                this.watcher.EnableRaisingEvents = true;
                Console.WriteLine($"Файл {e.FullPath} переименован");
                this.CreateBackup(e, "(rename)");
            }
        }
    }
}
