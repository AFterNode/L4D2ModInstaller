using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4D2ModInstaller.Utils
{
    internal class FileUtils
    {
        public static void DeletFolder(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (var file in di.GetFiles("*", SearchOption.AllDirectories))
            {
                file.Delete();
            }
        }

        public static void CopyDirToDir(string sourceDirName, string destDirName)
        {
            // 获取源文件夹和目标文件夹的信息
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();

            // 创建目标文件夹
            Directory.CreateDirectory(destDirName);

            // 复制所有文件
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
            }

            // 递归复制所有子文件夹
            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(destDirName, subdir.Name);
                CopyDirToDir(subdir.FullName, temppath);
            }
        }
        private static void GetFileList(DirectoryInfo dir, List<FileInfo> fileList)
        {
            fileList.AddRange(dir.GetFiles());
            foreach (DirectoryInfo directory in dir.GetDirectories()) GetFileList(directory, fileList);
        }
        private static void GetDirList(DirectoryInfo dir, List<DirectoryInfo> dirList)
        {
            dirList.AddRange(dir.GetDirectories());
            foreach (DirectoryInfo directory in dir.GetDirectories()) GetDirList(directory, dirList);
        }
    }
}
