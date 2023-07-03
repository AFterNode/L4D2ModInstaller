using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4D2ModInstaller.Utils
{
    internal class ZipUtils
    {
        public static void ExtractToDirectory(string zip, string target)
        {
            ZipStrings.CodePage = Encoding.GetEncoding("GBK").CodePage;

            if (!Directory.Exists(target)) Directory.CreateDirectory(target);

            ZipInputStream zis = new ZipInputStream(File.OpenRead(zip));

            ZipEntry entry = zis.GetNextEntry();
            while (entry != null)
            {

                string targetPath = target + "\\" + entry.Name.Replace("/", "\\");

                // 如果项是一个文件，创建一个新文件并复制数据
                if (!entry.IsDirectory)
                {
                    using (FileStream streamWriter = File.Create(targetPath))
                    {
                        byte[] data = new byte[2048];
                        while (true)
                        {
                            int size = zis.Read(data, 0, data.Length);
                            if (size > 0)
                            {
                                streamWriter.Write(data, 0, size);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                // 如果项是一个目录，创建一个新目录
                else
                {
                    Directory.CreateDirectory(targetPath);
                }

                entry = zis.GetNextEntry();
            }
        }
    }
}
