using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4D2ModInstaller.Utils
{
    internal class L4D2
    {

        public static void CopyAndCompressFile(string path, Label lb, ProgressBar pb, string target)
        {
            lb.Text = "创建文件";
            FileStream stream = new FileStream(target, FileMode.Create);
            ZipArchive arch = new ZipArchive(stream, ZipArchiveMode.Create);

            lb.Text = "解析目录";
            DirectoryInfo l4d2 = new DirectoryInfo(path + "\\left4dead2");
            DirectoryInfo dlc1 = new DirectoryInfo(path + "\\left4dead2_dlc1");
            DirectoryInfo dlc2 = new DirectoryInfo(path + "\\left4dead2_dlc2");
            DirectoryInfo dlc3 = new DirectoryInfo(path + "\\left4dead2_dlc3");
            DirectoryInfo update = new DirectoryInfo(path + "\\update");

            List<FileInfo> files = new List<FileInfo>();
            files.AddRange(l4d2.GetFiles("*", SearchOption.AllDirectories));
            files.AddRange(dlc2.GetFiles("*", SearchOption.AllDirectories));
            files.AddRange(dlc3.GetFiles("*", SearchOption.AllDirectories));
            files.AddRange(update.GetFiles("*", SearchOption.AllDirectories));

            pb.Maximum = files.Count;
            foreach (var file in files)
            {
                string entryName = file.FullName.Substring(path.Length + 1);
                lb.Text = entryName;
                ZipArchiveEntry entry = arch.CreateEntry(entryName);
                using (FileStream fs = new FileStream(file.FullName, FileMode.Open))
                {
                    using (Stream s = entry.Open()) fs.CopyTo(s);
                }
                pb.Value += 1;
            }
            lb.Text = "操作完成";
        }

        public static void PreprocessFiles(string path, Label lb, bool processVoiceMod, bool processV1Voice, bool processAddons)
        {


            if (processVoiceMod)
            {
                lb.Text = "预处理二代语音";
                Utils.FileUtils.DeletFolder(path + "\\left4dead2\\sound\\player\\survivor\\voice");
                if (Directory.Exists(path + "\\update\\sound\\player\\survivor\\voice")) Utils.FileUtils.DeletFolder(path + "\\update\\sound\\player\\survivor\\voice");
            }

            if (processV1Voice)
            {
                lb.Text = "预处理一代语音";
                Utils.FileUtils.DeletFolder(path + "\\left4dead2_dlc1\\sound\\player\\survivor\\voice");
                Utils.FileUtils.DeletFolder(path + "\\left4dead2_dlc2\\sound\\player\\survivor\\voice");
                Utils.FileUtils.DeletFolder(path + "\\left4dead2_dlc3\\sound\\player\\survivor\\voice");
                if (Directory.Exists(path + "\\update\\sound\\player\\survivor\\voice")) Utils.FileUtils.DeletFolder(path + "\\update\\sound\\player\\survivor\\voice");
            }

            if (processAddons)
            {
                DirectoryInfo di = new DirectoryInfo(path + "\\left4dead2\\addons");
                foreach (var f in di.GetFiles("*", SearchOption.AllDirectories))
                {
                    if (!f.FullName.Contains("\\workshop\\")) f.Delete();
                }
            }

            lb.Text = "预处理update";
            Directory.Move(path + "\\update", path + "\\update_bak");

            lb.Text = "操作完成";
        }
    }
}
