using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Concurrent;
using System.Windows.Forms;

namespace Music_Player_Project
{
    public class Util
    {

        public static string MusicFolderPath = "C:\\Users\\amrs5\\Music\\MusicFile";

        public static bool CreateFolderIfNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex) { return false; }
            }
            return true;
        }

        public static bool CopyFile(string FileName, string FolderPath)
        {
            if (!CreateFolderIfNotExist(FolderPath))
                return false;

            try
            {
                File.Copy(FileName, FolderPath);
            }
            catch (Exception ex) { return false; }

            return true;
        }

        public static bool DeleteMusicFolder(string FolderPath)
        {
            if (Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.Delete(FolderPath);
                    return true;
                }
                catch { return false; }
            }
            return true;
        }

        public static bool DeleteFile(string FileNeme, string FolderPath)
        {
            if (!File.Exists(FileNeme) || !Directory.Exists(FolderPath))
                return false;

            try
            {
                File.Delete(FileNeme);
                return true;
            }
            catch { return false; }

        }

        public static int? GetCountOfFileInFolder(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
                return null;

            try
            {
                DirectoryInfo Folder = new DirectoryInfo(FolderPath);
                return Folder.GetFiles().Length;
            }
            catch { return null; }
        }

        public static List<string> GetAllMusicNameFromMusicProjectFile()
        {
            List<string> MusicName = new List<string>();
            
            DirectoryInfo MusicFolder = new DirectoryInfo(Util.MusicFolderPath);

            FileInfo[] MusicFiles = MusicFolder.GetFiles();

            foreach(FileInfo MusicFile in MusicFiles)
            {
                MusicName.Add(Path.GetFileName(MusicFile.Name));
            }

            return MusicName;
        }



        public static List<string> ScanDirectoryForMp3Files(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            List<string> MusicFile = new List<string>();

            bool IsRoot = Directory.GetDirectoryRoot(dir.FullName) == dir.FullName;

            if (dir.Attributes.HasFlag(System.IO.FileAttributes.System) && !IsRoot)
            {
                return MusicFile;
            }
            try
            {
                MusicFile.AddRange(Directory.GetFiles(path, "*.mp3"));
            }
            catch (UnauthorizedAccessException e)
            {
                return MusicFile;
            }
            catch (Exception e)
            {
                return MusicFile;
            }
            try
            {
                foreach (string NewDir in Directory.GetDirectories(path))
                {
                    MusicFile.AddRange(ScanDirectoryForMp3Files(NewDir));
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Error"); }
            return MusicFile;
        }

        public static List<string> ScanDirectoryForMp3FilesParallel(string path)// using MultiThreading
        {
            ConcurrentBag<string> mp3Files = new ConcurrentBag<string>();
            var dirInfo = new DirectoryInfo(path);
            var isRoot = dirInfo.Root.FullName.Equals(dirInfo.FullName);

            if (dirInfo.Attributes.HasFlag(FileAttributes.System) && !isRoot)
            {
                return new List<string>(mp3Files);
            }

            try
            {
                foreach (var mp3File in Directory.GetFiles(path, "*.mp3"))
                {
                    mp3Files.Add(mp3File);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access denied to {path}: {ex.Message}");
                return new List<string>(mp3Files);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred accessing {path}: {ex.Message}");
                return new List<string>(mp3Files);
            }

            // Recursively scan subdirectories in parallel
            string[] directories;
            try
            {
                directories = Directory.GetDirectories(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred getting directories in {path}: {ex.Message}");
                return new List<string>(mp3Files);
            }

            Parallel.ForEach(directories, (directory) =>
            {
                var subDirFiles = ScanDirectoryForMp3FilesParallel(directory); // Recursive call
                foreach (var file in subDirFiles)
                {
                    mp3Files.Add(file);
                }
            });

            return new List<string>(mp3Files);
        }

    }
}
